using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Here was the first attempt to make the contact object
// decided to click project and make new class contactObj.cs
//leaving this for now in case it's needed to be referenced

namespace BlazorContactApp.Data
{

    public class Contact
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

          public override String ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + " | Phone Number: " + this.PhoneNumber + " | Birth Date: " + this.BirthDate;
        }
    }

}
// List ContactList = new List<ContactObj> {};
// attempted to make list of contact object here and failed