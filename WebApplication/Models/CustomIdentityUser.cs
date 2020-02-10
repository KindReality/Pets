using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public string Notes { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
