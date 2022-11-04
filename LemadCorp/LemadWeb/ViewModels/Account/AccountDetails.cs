using System.Collections.Generic;

namespace LemadWeb.ViewModels.Account
{
    public class AccountDetails
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<LemadDb.Domain.User.AdresseCivique> AdresseCiviques { get; set; } = new List<LemadDb.Domain.User.AdresseCivique>();
    }
}
