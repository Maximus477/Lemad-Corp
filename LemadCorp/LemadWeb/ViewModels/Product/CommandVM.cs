using LemadDb.Domain.User;

namespace LemadWeb.ViewModels.Product
{
    public class CommandVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AdresseCivique Address { get; set; }
    }
}
