using LemadDb.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.Entities
{
    public class Command
    {
        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        // nav
        public IEnumerable<Product> Products { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
