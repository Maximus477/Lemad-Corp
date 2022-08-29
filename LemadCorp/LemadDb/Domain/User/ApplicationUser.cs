using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.User
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string EntrepriseName { get; set; }

        public byte[] Photo { get; set; }
    }
}
