using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LemadDb.Data.Status;

namespace LemadDb.Domain.Entities
{
    public class Principals
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        #region Stats

        #endregion

        [Required]
        [DataType(dataType: DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public byte Discount { get; set; }

        [Required]
        public ProductStatus Status { get; set; }
    }
}
