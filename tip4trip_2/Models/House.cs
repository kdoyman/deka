﻿using System;
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
        //int y = Convert.ToInt32(DateTime.Now);
       
        [DataType(DataType.Date)]
        [Display(Name ="bale")]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]//jjkkk
        public DateTime DateToRent { get; set; }

        public Location Location { get; set; }
        [Display(Name = "Location")]
        public int LocationId { get; set; }
    }
}