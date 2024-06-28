using System;
using System.Windows.Forms;

namespace FlightBookingApp
{
    public partial class BoardingPassForm : Form
    {
        public BoardingPassForm(BoardingPass boardingPass)
        {
            InitializeComponent();
            InitializeCustomComponents(boardingPass);
        }

        private void InitializeCustomComponents(BoardingPass boardingPass)
        {
            boardingPassLabel.Text = $"Рейс: {boardingPass.FlightNumber}\n" +
                                     $"Ім'я пасажира: {boardingPass.PassengerName}\n" +
                                     $"Номер паспорта: {boardingPass.PassportNumber}\n" +
                                     $"Номер місця: {boardingPass.SeatNumber}\n" +
                                     $"Відправлення: {boardingPass.Departure}\n" +
                                     $"Прибуття: {boardingPass.Arrival}\n" +
                                     $"Час відправлення: {boardingPass.DepartureTime}\n" +
                                     $"Час прибуття: {boardingPass.ArrivalTime}\n" +
                                     $"Ціна квитка: {boardingPass.TicketPrice.ToString("C", new System.Globalization.CultureInfo("en-US"))}\n" +
                                     $"Дата бронювання: {boardingPass.BookingDate.ToString("dd-MM-yyyy HH:mm")}";

            exitButton.Click += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}