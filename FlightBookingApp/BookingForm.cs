using System;
using System.Globalization;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class BookingForm : Form
    {
        private Flight flight;
        public BoardingPass BoardingPass { get; private set; }

        public BookingForm(Flight flight)
        {
            InitializeComponent();
            this.flight = flight;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            flightInfoLabel.Text = $"Рейс: {flight.FlightNumber}, {flight.Airplane.Airline}, {flight.Departure} - {flight.Arrival}, Час: {flight.DepartureTime} - {flight.ArrivalTime}";
            confirmButton.Click += ConfirmButton_Click;
            exitButton.Click += ExitButton_Click;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string passengerName = passengerNameTextBox.Text;
                string passportNumber = passportNumberTextBox.Text;
                int ticketCount = (int)ticketCountNumericUpDown.Value;

                flight.BookTickets(ticketCount);
                double totalPrice = flight.TicketPrice * ticketCount * 1.02;
                int seatNumber = flight.AvailableSeats + 1;

                BoardingPass = new BoardingPass(flight.FlightNumber, passengerName, passportNumber, seatNumber, flight.Departure, flight.Arrival, flight.DepartureTime, flight.ArrivalTime, totalPrice, DateTime.Now);
                MessageBox.Show($"Квитки успішно заброньовані!\nІм'я пасажира: {passengerName}\nНомер паспорта: {passportNumber}\nКількість квитків: {ticketCount}\nЗагальна ціна: {totalPrice.ToString("C", new CultureInfo("en-US"))}");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при бронюванні квитків: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
