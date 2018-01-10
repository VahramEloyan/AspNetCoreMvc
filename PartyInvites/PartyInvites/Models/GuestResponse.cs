using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="please enter your valid email address")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Please Enter Your Phone")]
        public string Phone { set; get; }
        [Required(ErrorMessage = "Please Enter Yes or NO")]
        public bool? WillAttend { set; get; }

    }
}
