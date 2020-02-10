using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }

        public string CustomIdentityUserID { get; set; }
        [ForeignKey("CustomIdentityUserID")]
        public CustomIdentityUser CustomIdentityUser { get; set; }
    }
}
