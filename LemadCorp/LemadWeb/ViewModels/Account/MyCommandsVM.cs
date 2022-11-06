using LemadDb.Domain.Entities;
using System;
using System.Collections.Generic;
using static LemadDb.Data.Enumerable;

namespace LemadWeb.ViewModels.Account
{
    public class MyCommandsVM
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullAddress { get; set; }
        public decimal Total { get; set; }
        public CommandStatus Status { get; set; }
        public List<LemadDb.Domain.Entities.Product> Products { get; set; }
    }
}
