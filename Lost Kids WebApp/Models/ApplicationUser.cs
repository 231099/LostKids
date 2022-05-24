using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lost_Kids_WebApp.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }

        public string StreetAddress { get; set; }

        public string PostalCode { get; set; }
        public string Governorate { get; set; }

        public string  City { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}
