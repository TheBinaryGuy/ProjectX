﻿using System.ComponentModel.DataAnnotations;

namespace ProjectX.App.Models
{
    public class DataProtectionKey
    {
        [Key]
        public string FriendlyName { get; set; }
        public string XmlData { get; set; }
    }
}
