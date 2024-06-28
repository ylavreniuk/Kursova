using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class MainForm : Form
    {
        private List<Flight> flights = new List<Flight>();
        private List<BoardingPass> boardingPasses = new List<BoardingPass>();
        private List<Airplane> airplanes = new List<Airplane>();

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadInitialAirplanes();
            LoadInitialFlights();
            UpdateFlightList();
        }

        private void InitializeCustomComponents()
        {
            departureComboBox.Items.AddRange(Capitals);
            arrivalComboBox.Items.AddRange(Capitals);

            searchButton.Click += SearchButton_Click;
            addFlightButton.Click += AddFlightButton_Click;
            editFlightButton.Click += EditFlightButton_Click;
            deleteFlightButton.Click += DeleteFlightButton_Click;
            bookTicketButton.Click += BookTicketButton_Click;
            exitButton.Click += ExitButton_Click;
            saveButton.Click += SaveButton_Click;
            loadButton.Click += LoadButton_Click;
            viewBoardingPassButton.Click += ViewBoardingPassButton_Click;
            resetButton.Click += ResetButton_Click;

            flightsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            flightsDataGridView.MultiSelect = false;
            flightsDataGridView.ReadOnly = true;

            flightsDataGridView.Columns.Add("FlightNumber", "Номер рейсу");
            flightsDataGridView.Columns.Add("Airline", "Авіакомпанія");
            flightsDataGridView.Columns.Add("Departure", "Відправлення");
            flightsDataGridView.Columns.Add("Arrival", "Прибуття");
            flightsDataGridView.Columns.Add("Stopovers", "Проміжні зупинки");
            flightsDataGridView.Columns.Add("DepartureTime", "Час відправлення");
            flightsDataGridView.Columns.Add("ArrivalTime", "Час прибуття");
            flightsDataGridView.Columns.Add("FlightDays", "Дні польотів");
            flightsDataGridView.Columns.Add("AvailableSeats", "Вільні місця");
            flightsDataGridView.Columns.Add("TicketPrice", "Ціна квитка");
            flightsDataGridView.Columns.Add("Airplane", "Літак");
        }

        private void LoadInitialAirplanes()
        {
            airplanes.Add(new Airplane("Boeing 737", 180, 2.5, "Airline A"));
            airplanes.Add(new Airplane("Airbus A320", 150, 2.0, "Airline B"));
            airplanes.Add(new Airplane("Boeing 777", 300, 3.0, "Airline C"));
        }

        private void LoadInitialFlights()
        {
            flights.Add(new Flight("AA101", airplanes[0], "Київ", "Лондон", new List<string> { "Варшава" }, "08:00", "10:00", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday }, 150, 200.50));
            flights.Add(new Flight("BA202", airplanes[1], "Лондон", "Київ", new List<string> { "Прага" }, "09:00", "12:00", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Thursday, DayOfWeek.Saturday }, 120, 180.75));
            flights.Add(new Flight("CA303", airplanes[2], "Київ", "Париж", new List<string> { "Відень" }, "06:00", "08:00", new List<DayOfWeek> { DayOfWeek.Sunday, DayOfWeek.Monday }, 100, 150.30));
            flights.Add(new Flight("DA404", airplanes[0], "Париж", "Київ", new List<string> { "Берлін" }, "10:00", "12:30", new List<DayOfWeek> { DayOfWeek.Wednesday, DayOfWeek.Friday }, 80, 170.40));
            flights.Add(new Flight("EA505", airplanes[1], "Київ", "Берлін", new List<string> { "Прага" }, "07:00", "09:00", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 90, 160.25));
            flights.Add(new Flight("FA606", airplanes[2], "Берлін", "Київ", new List<string> { "Варшава" }, "11:00", "13:00", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }, 85, 155.45));
            flights.Add(new Flight("GA707", airplanes[0], "Київ", "Варшава", new List<string> { "Берлін" }, "08:30", "10:30", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 70, 140.15));
            flights.Add(new Flight("HA808", airplanes[1], "Варшава", "Київ", new List<string> { "Прага" }, "12:30", "14:30", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 75, 145.35));
            flights.Add(new Flight("IA909", airplanes[2], "Київ", "Прага", new List<string> { "Варшава" }, "09:30", "11:30", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }, 60, 130.20));
            flights.Add(new Flight("JA010", airplanes[0], "Прага", "Київ", new List<string> { "Берлін" }, "13:30", "15:30", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 65, 135.40));
            flights.Add(new Flight("KA111", airplanes[1], "Київ", "Рим", new List<string> { "Прага" }, "10:00", "12:30", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 50, 120.25));
            flights.Add(new Flight("LA212", airplanes[2], "Рим", "Київ", new List<string> { "Відень" }, "14:00", "16:30", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }, 55, 125.45));
            flights.Add(new Flight("MA313", airplanes[0], "Київ", "Мадрид", new List<string> { "Барселона" }, "11:00", "14:00", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 45, 110.15));
            flights.Add(new Flight("NA414", airplanes[1], "Мадрид", "Київ", new List<string> { "Рим" }, "15:00", "18:00", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 50, 115.35));
            flights.Add(new Flight("OA515", airplanes[2], "Київ", "Барселона", new List<string> { "Мадрид" }, "12:00", "15:00", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }, 40, 100.20));
            flights.Add(new Flight("PA616", airplanes[0], "Барселона", "Київ", new List<string> { "Рим" }, "16:00", "19:00", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 45, 105.40));
            flights.Add(new Flight("QA717", airplanes[1], "Київ", "Будапешт", new List<string> { "Відень" }, "13:00", "15:00", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 35, 90.25));
            flights.Add(new Flight("RA818", airplanes[2], "Будапешт", "Київ", new List<string> { "Прага" }, "17:00", "19:00", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday }, 40, 95.45));
            flights.Add(new Flight("SA919", airplanes[0], "Київ", "Відень", new List<string> { "Будапешт" }, "14:00", "16:00", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Friday }, 30, 80.15));
            flights.Add(new Flight("TA020", airplanes[1], "Відень", "Київ", new List<string> { "Будапешт" }, "18:00", "20:00", new List<DayOfWeek> { DayOfWeek.Thursday, DayOfWeek.Saturday }, 35, 85.35));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string departure = departureComboBox.SelectedItem.ToString();
            string arrival = arrivalComboBox.SelectedItem.ToString();
            DateTime date = dateTimePicker.Value;

            List<Flight> directFlights = SearchDirectFlights(departure, arrival, date);
            if (directFlights.Count > 0)
            {
                DisplaySearchResults(directFlights);
            }
            else
            {
                List<Flight> connectingFlights = SearchConnectingFlights(departure, arrival, date);
                DisplaySearchResults(connectingFlights);
            }
        }

        private List<Flight> SearchDirectFlights(string departure, string arrival, DateTime date)
        {
            List<Flight> results = new List<Flight>();
            DayOfWeek day = date.DayOfWeek;

            foreach (var flight in flights)
            {
                if (flight.Departure == departure && flight.Arrival == arrival && flight.IsFlyingOn(day) && flight.HasAvailableSeats())
                {
                    results.Add(flight);
                }
            }
            results.Sort();
            return results;
        }

        private List<Flight> SearchConnectingFlights(string departure, string arrival, DateTime date)
        {
            List<Flight> results = new List<Flight>();
            DayOfWeek day = date.DayOfWeek;

            foreach (var flight1 in flights)
            {
                if (flight1.Departure == departure && flight1.IsFlyingOn(day) && flight1.HasAvailableSeats())
                {
                    foreach (var flight2 in flights)
                    {
                        if (flight2.Departure == flight1.Arrival && flight2.Arrival == arrival && flight2.IsFlyingOn(day) && flight2.HasAvailableSeats())
                        {
                            results.Add(flight1);
                            results.Add(flight2);
                        }
                    }
                }
            }
            results.Sort();
            return results;
        }

        private void DisplaySearchResults(List<Flight> searchResults)
        {
            flightsDataGridView.Rows.Clear();
            foreach (var flight in searchResults)
            {
                flightsDataGridView.Rows.Add(
                    flight.FlightNumber,
                    flight.Airplane.Airline,
                    flight.Departure,
                    flight.Arrival,
                    string.Join(", ", flight.Stopovers),
                    flight.DepartureTime,
                    flight.ArrivalTime,
                    string.Join(", ", flight.FlightDays),
                    flight.AvailableSeats,
                    flight.TicketPrice.ToString("C", new CultureInfo("en-US")),
                    $"{flight.Airplane.Model} - {flight.Airplane.Airline}"
                );
            }
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            FlightForm flightForm = new FlightForm(airplanes);
            if (flightForm.ShowDialog() == DialogResult.OK)
            {
                flights.Add(flightForm.Flight);
                UpdateFlightList();
            }
        }

        private void EditFlightButton_Click(object sender, EventArgs e)
        {
            if (flightsDataGridView.SelectedRows.Count > 0)
            {
                int index = flightsDataGridView.SelectedRows[0].Index;
                Flight selectedFlight = flights[index];
                FlightForm flightForm = new FlightForm(selectedFlight, airplanes);
                if (flightForm.ShowDialog() == DialogResult.OK)
                {
                    flights[index] = flightForm.Flight;
                    UpdateFlightList();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс для редагування.");
            }
        }

        private void DeleteFlightButton_Click(object sender, EventArgs e)
        {
            if (flightsDataGridView.SelectedRows.Count > 0)
            {
                int index = flightsDataGridView.SelectedRows[0].Index;
                flights.RemoveAt(index);
                UpdateFlightList();
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс для видалення.");
            }
        }

        private void BookTicketButton_Click(object sender, EventArgs e)
        {
            if (flightsDataGridView.SelectedRows.Count > 0)
            {
                int index = flightsDataGridView.SelectedRows[0].Index;
                Flight selectedFlight = flights[index];
                BookingForm bookingForm = new BookingForm(selectedFlight);
                if (bookingForm.ShowDialog() == DialogResult.OK)
                {
                    boardingPasses.Add(bookingForm.BoardingPass);
                    UpdateFlightList();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс для бронювання квитка.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FlightData.SaveFlights(flights);
            MessageBox.Show("Рейси збережено у файл.");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            flights = FlightData.LoadFlights();
            UpdateFlightList();
            MessageBox.Show("Рейси завантажено з файлу.");
        }

        private void ViewBoardingPassButton_Click(object sender, EventArgs e)
        {
            if (boardingPasses.Count > 0)
            {
                BoardingPass boardingPass = boardingPasses[boardingPasses.Count - 1];
                BoardingPassForm boardingPassForm = new BoardingPassForm(boardingPass);
                boardingPassForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Немає заброньованих квитків для відображення.");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateFlightList();
        }

        private void UpdateFlightList()
        {
            flightsDataGridView.Rows.Clear();
            foreach (var flight in flights)
            {
                flightsDataGridView.Rows.Add(
                    flight.FlightNumber,
                    flight.Airplane.Airline,
                    flight.Departure,
                    flight.Arrival,
                    string.Join(", ", flight.Stopovers),
                    flight.DepartureTime,
                    flight.ArrivalTime,
                    string.Join(", ", flight.FlightDays),
                    flight.AvailableSeats,
                    flight.TicketPrice.ToString("C", new CultureInfo("en-US")),
                    $"{flight.Airplane.Model} - {flight.Airplane.Airline}"
                );
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void viewBoardingPassButton_Click_1(object sender, EventArgs e)
        {

        }

        private void addFlightButton_Click_1(object sender, EventArgs e)
        {

        }

        private void editFlightButton_Click_1(object sender, EventArgs e)
        {

        }

        private void deleteFlightButton_Click_1(object sender, EventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {

        }

        private void bookTicketButton_Click_1(object sender, EventArgs e)
        {

        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}


