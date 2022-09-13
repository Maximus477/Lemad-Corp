using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemadDb.Domain.Entities
{
    public class Pilots
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(dataType:DataType.Currency)]
        public decimal Price { get; set; }
    }
}
