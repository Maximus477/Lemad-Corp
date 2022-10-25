using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.User
{
    public class AddressUser
    {
        [Required]
        public Guid AddressId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        // nav
        public ApplicationUser ApplicationUser { get; set; }

        public AdresseCivique AdresseCivique { get; set; }
    }
}
