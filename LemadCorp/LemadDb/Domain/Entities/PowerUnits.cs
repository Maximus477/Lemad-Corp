using System.ComponentModel.DataAnnotations;

namespace LemadDb.Domain.Entities
{
    public class PowerUnits
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(dataType: DataType.Currency)]
        public decimal Price { get; set; }
    }
}
