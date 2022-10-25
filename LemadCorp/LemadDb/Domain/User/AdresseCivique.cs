using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.User
{
    public class AdresseCivique
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string PostalCode { get; set; }

        public ICollection<AddressUser> AddressUser { get; set; }
    }
}
