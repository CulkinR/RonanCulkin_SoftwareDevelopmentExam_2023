using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RonanCulkin_SoftwareDevelopmentExam_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MovieData db = new MovieData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from m in db.Movies
                        select m;

            lbx_movieListings.ItemsSource = query.ToList();
        }

        private void lbx_movieListings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get movie synopsis
            Movie selectedMovie = lbx_movieListings.SelectedItem as Movie;
            tbk_movieSynopsis.Text = selectedMovie.Description;

            // Get available seats
            //available seats variable
            int availableSeats = 100;

            //List<Booking> getBookings = (List<Booking>)(from m in db.Movies
            //                  select m.Bookings);

            //foreach (Booking booking in getBookings)
            //{
            //    availableSeats -= booking.NumberOfTickets;
            //}







            // Display seats used
            tbk_availableSeats.Text = availableSeats.ToString();

        }

        private void btn_bookSeats_Click(object sender, RoutedEventArgs e)
        {
            // Get selected movieID
            Movie selectedMovie = lbx_movieListings.SelectedItem as Movie;
            int movieID = selectedMovie.MovieID;


            // Booking form object
            Booking booking = new Booking()
            {
                BookingDate = (DateTime)dpk_bookingDate.SelectedDate,
                NumberOfTickets = Convert.ToInt32(tbx_requiredSeats.Text),
                Movie = selectedMovie
            };

            db.Bookings.Add(booking);
            db.SaveChanges();
            
        }
    }
}
