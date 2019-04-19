using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tip4trip_2.Models
{
    public class Reservation
    {
        public House HouseRes { get; set; }
        public int HouseId { get; set; }
        public string renter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }
        public int Occupants { get; set; }

        public DateTime DateOfBooking { get; set; }
        public string CustommerComments { get; set; }
        public double PricePerNightCharged { get; set; }
            
        
        int Status = 1; // 1 means that the status is Active

    }
}