using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZOH.Models
{
    public class Customer
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int TelNumber { get; set; }
        public Room Room { get; set; }
        public byte RoomId { get; set; }
    }
}