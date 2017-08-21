using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class DaysOfWeek
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Day of Week")]
        public string Day { get; set; }
    }
}