using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tip4trip_2.Models
{
    public class Location
    {
      public int Id { get; set; }
        [Required]
        public string nameloc { get; set; }
    }
}