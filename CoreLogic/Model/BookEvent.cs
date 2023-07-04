using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Model
{
    public class BookEvent
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string? Venue { get; set; }
        public int NoofGuest { get; set; }
        [DataType(DataType.Date)]
        public string BookingDate { get; set; }

    }
}
