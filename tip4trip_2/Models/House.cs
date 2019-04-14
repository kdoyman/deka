using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tip4trip_2.Models
{
    public class House
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Give the Address please !")]
        public string Address { get; set; }
        

        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]
        public DateTime DateToRent { get; set; }
    }
}