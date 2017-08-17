using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class TrashPickup
    {
        [Key]
        public int Id { get; set; }
        public decimal AmountOwed { get; set; }
        public string PickupDay { get; set; }
        public string ChangePickup { get; set; }
    }
}