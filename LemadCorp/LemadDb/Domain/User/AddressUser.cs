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
        public Guid AdresseCiviqueId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
    }
}
