using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Please enter whether you are attending")]
        public bool? willAttend { get; set; }
        // question mark allows bool to remain undefined
    }
}