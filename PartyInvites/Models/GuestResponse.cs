using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please Enter you Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter a valid Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please Enter your Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify whether you'll attend")]
        public bool? WillAttend { get; set; }

    }
}