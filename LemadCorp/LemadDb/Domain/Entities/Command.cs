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
        public Guid UserId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
