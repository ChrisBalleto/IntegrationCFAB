using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DateNightApp.Models
{
    public class Date
    {
        public int Id { get; set; }

        public DateTime DayOfDate { get; set;}

        public int UserId { get; set; }

        public bool IsChatty { get; set; }

        public bool IsActive { get; set; }

        public bool IsArtsy { get; set; }

        public Restaurant Restaurant { get; set; }

        public int RestaurantId { get; set; }

    }
}