using LemadDb.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LemadWeb.ViewModels.Product
{
    public class ListProductVM
    {
        [Required]
        public List<Pilots> Pilots { get; set; }

        [Required]
        public List<Engineers> Engineers { get; set; }

        [Required]
        public List<Mechanics> Mechanics { get; set; }

        [Required]
        public List<Principals> Principals { get; set; }

        [Required]
        public List<PowerUnits> PowerUnits { get; set; }
    }
}
