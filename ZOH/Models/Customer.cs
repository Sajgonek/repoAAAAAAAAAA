using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZOH.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public byte Id { get; set; }
        [Required(ErrorMessage = "Please enter customer's Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter customer's Email Address.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please enter customer's Telephone Number.")]
        [Display(Name = "Telephone Number")]
        public int TelNumber { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Required(ErrorMessage = "Please select customer's Membership type.")]
        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }
    }
}