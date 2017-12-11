using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZOH.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public byte Id { get; set; }
        public RoomType RoomType { get; set; }
        [Required]
        public byte RoomTypeId { get; set; }
    }
}