using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZOH.Models
{
    public class Customer
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public int TelNumber { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Required]
        public byte MembershipTypeId { get; set; }
    }
}