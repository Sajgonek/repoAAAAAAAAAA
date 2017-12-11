﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZOH.Models
{
    public class Room
    {
        public byte Id { get; set; }
        public RoomType RoomType { get; set; }
        [Required]
        public byte RoomTypeId { get; set; }
    }
}