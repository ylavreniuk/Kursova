using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class FlightForm : Form
    {
        public Flight Flight { get; private set; }
        private List<Airplane> airplanes;

        public FlightForm(List<Airplane> airplanes)
        {
            InitializeComponent();
            this.airplanes = airplanes;
            InitializeCustomComponents();
            PopulateAirplaneComboBox();
        }

        public FlightForm(Flight flight, List<Airplane> airplanes) : this(airplanes)
        {
            Flight = flight;
            flightNumberTextBox.Text = flight.FlightNumber;
            airlineComboBox.SelectedItem = $"{flight.Airplane.Model} - {flight.Airplane.Airline}";
            departureComboBox.SelectedItem = flight.Departure;
            arrivalComboBox.SelectedItem = flight.Arrival;
            stopoversTextBox.Text = string.Join(", ", flight.Stopovers);
            departureTimeComboBox.SelectedItem = flight.DepartureTime;
            arrivalTimeComboBox.SelectedItem = flight.ArrivalTime;

            if (flight.AvailableSeats >= availableSeatsNumericUpDown.Minimum && flight.AvailableSeats <= availableSeatsNumericUpDown.Maximum)
            {
                availableSeatsNumericUpDown.Value = flight.AvailableSeats;
            }
            else
            {
                availableSeatsNumericUpDown.Value = availableSeatsNumericUpDown.Minimum;
            }

            ticketPriceTextBox.Text = flight.TicketPrice.ToString();

            foreach (DayOfWeek day in flight.FlightDays)
            {
                flightDaysCheckedListBox.SetItemChecked((int)day, true);
            }
        }

        private void InitializeCustomComponents()
        {
            departureComboBox.Items.AddRange(Capitals);
            arrivalComboBox.Items.AddRange(Capitals);

            for (int i = 0; i < 24; i++)
            {
                departureTimeComboBox.Items.Add(i.ToString("D2") + ":00");
                departureTimeComboBox.Items.Add(i.ToString("D2") + ":30");
                arrivalTimeComboBox.Items.Add(i.ToString("D2") + ":00");
                arrivalTimeComboBox.Items.Add(i.ToString("D2") + ":30");
            }

            flightDaysCheckedListBox.Items.AddRange(new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Нд" });

            saveButton.Click += SaveButton_Click;
            exitButton.Click += ExitButton_Click;
        }

        private void PopulateAirplaneComboBox()
        {
            foreach (var airplane in airplanes)
            {
                airlineComboBox.Items.Add($"{airplane.Model} - {airplane.Airline}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Flight == null)
                {
                    Flight = new Flight();
                }

                Flight.FlightNumber = flightNumberTextBox.Text;
                string selectedAirplane = airlineComboBox.SelectedItem.ToString();
                Flight.Airplane = airplanes.First(a => $"{a.Model} - {a.Airline}" == selectedAirplane);
                Flight.Departure = departureComboBox.SelectedItem.ToString();
                Flight.Arrival = arrivalComboBox.SelectedItem.ToString();
                Flight.Stopovers = new List<string>(stopoversTextBox.Text.Split(','));
                Flight.DepartureTime = departureTimeComboBox.SelectedItem.ToString();
                Flight.ArrivalTime = arrivalTimeComboBox.SelectedItem.ToString();
                Flight.FlightDays = new List<DayOfWeek>();

                foreach (object item in flightDaysCheckedListBox.CheckedItems)
                {
                    Flight.FlightDays.Add(TranslateDayToDayOfWeek(item.ToString()));
                }

                Flight.AvailableSeats = (int)availableSeatsNumericUpDown.Value;
                Flight.TicketPrice = double.Parse(ticketPriceTextBox.Text);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні рейсу: " + ex.Message);
            }
        }

        private DayOfWeek TranslateDayToDayOfWeek(string day)
        {
            switch (day)
            {
                case "Нд":
                    return DayOfWeek.Sunday;
                case "Пн":
                    return DayOfWeek.Monday;
                case "Вт":
                    return DayOfWeek.Tuesday;
                case "Ср":
                    return DayOfWeek.Wednesday;
                case "Чт":
                    return DayOfWeek.Thursday;
                case "Пт":
                    return DayOfWeek.Friday;
                case "Сб":
                    return DayOfWeek.Saturday;
                default:
                    throw new ArgumentException("Неправильний день тижня: " + day);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private readonly string[] Capitals = new string[]
        {
            "Абу-Дабі", "Абуджа", "Абуджа", "Акра", "Андорра-ла-Велья", "Анкара", "Антананаріву", "Апіа", "Асмера", "Астана",
            "Асунсьйон", "Афіни", "Багдад", "Баку", "Бамако", "Бангкок", "Банжул", "Бастер", "Бейрут", "Белград",
            "Бельмопан", "Берлін", "Берн", "Бішкек", "Братислава", "Бразиліа", "Бріджтаун", "Брюссель", "Будапешт", "Буенос-Айрес",
            "Бужумбура", "Вадуц", "Валетта", "Варшава", "Вашингтон", "Веллінгтон", "Вільнюс", "Віндгук", "Вікторія", "Віфлеєм",
            "Гавана", "Габороне", "Гамільтон", "Гватемала", "Гельсінкі", "Гондурас", "Гонконг", "Гренада", "Гуатапа", "Дамаск",
            "Дакка", "Дар-ес-Салам", "Джакарта", "Джібуті", "Джуба", "Додома", "Доха", "Дублін", "Душанбе", "Єреван",
            "Єрусалим", "Загреб", "Хараре", "Кабул", "Кампала", "Канберра", "Каракас", "Катманду", "Каїр", "Київ",
            "Кігалі", "Кінгстаун", "Кіншаса", "Кито", "Куала-Лумпур", "Лондон", "Луанда", "Лусака", "Люксембург", "Мадрид",
            "Манагуа", "Манама", "Мапуту", "Масеру", "Маскат", "Мбабане", "Мексика", "Мінськ", "Могадішо", "Монако",
            "Монровія", "Монтевідео", "Москва", "Найробі", "Нассау", "Нджамена", "Нікосія", "Нуакшот", "Нукус", "Нур-Султан",
            "Осло", "Оттава", "Пекін", "П'ятикватемала", "Пхеньян", "Рабат", "Рига", "Рим", "Сан-Марино", "Сан-Сальвадор",
            "Санто-Домінго", "Сараєво", "Сеул", "Сінгапур", "Скоп'є", "Софія", "Стокгольм", "Сувон", "Таллінн", "Ташкент",
            "Тбілісі", "Тегеран", "Тирана", "Токіо", "Тріполі", "Туніс", "Улан-Батор", "Фуншал", "Фрітаун", "Ханой",
            "Хараре", "Хартум", "Хельсінкі", "Цейлон", "Ченнай", "Шанхай", "Шрі-Джаяварденепура-Котте", "Штрбско-Плесо", "Ямусукро", "Яунде"
        };

        private void flightNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

