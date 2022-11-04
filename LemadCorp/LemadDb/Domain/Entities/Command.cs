using LemadDb.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LemadDb.Data.Enumerable;

namespace LemadDb.Domain.Entities
{
    public class Command
    {
        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalWithDiscount { get; set; }
        public decimal TotalWithTaxes { get; set; }
        public CommandStatus Status { get; set; }
        //e(p.ex.confirmée, annulée, en préparation, en livraison, livrée, retournée)
        //public AdresseCivique AdresseCivique { get; set; }
        public List<CommandProduct> ProductIDs { get; set; }

        // nav
        //public List<int> ProductIDs { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
