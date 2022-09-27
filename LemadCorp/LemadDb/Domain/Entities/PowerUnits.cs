using System.ComponentModel.DataAnnotations;
using static LemadDb.Data.Status;

namespace LemadDb.Domain.Entities
{
    public class PowerUnits
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

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
