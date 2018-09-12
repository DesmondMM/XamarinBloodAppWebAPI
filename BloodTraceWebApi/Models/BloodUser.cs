using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BloodTraceWebApi.Models
{
    public class BloodUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter a valid phone number")]
        public string Phone { get; set; }
        public string Country { get; set; }
        public string BloodGroup { get; set; }
        public string ImagePath { get; set; }
        public int Date { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
    }
}