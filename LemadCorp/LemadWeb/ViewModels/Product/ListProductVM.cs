using LemadDb.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LemadWeb.ViewModels.Product
{
    public class ListProductVM
    {
        [Required]
        public List<Drivers> Pilots { get; set; }

        [Required]
        public List<TechnicalChiefs> Engineers { get; set; }

        [Required]
        public List<RaceEngineers> Mechanics { get; set; }

        [Required]
        public List<Principals> Principals { get; set; }

        [Required]
        public List<PowerUnits> PowerUnits { get; set; }
    }
}
