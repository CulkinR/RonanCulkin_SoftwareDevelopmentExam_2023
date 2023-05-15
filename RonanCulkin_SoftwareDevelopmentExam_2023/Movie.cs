using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RonanCulkin_SoftwareDevelopmentExam_2023
{
    public class Movie
    {
        // Variables
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public string Cast { get; set; }

        // Model relation (one movie with many bookings)
        public virtual List<Booking> Bookings { get; set; }

    }

    public class Booking
    {
        // Variables
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfTickets { get; set; }

        // Model relation (each booking has one movie)
        public virtual Movie Movie { get; set; }


    }

    public class MovieData: DbContext
    {
        public MovieData() : base("OODExam_RonanCulkin") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
