using name_sorter.Contracts.Models;

namespace name_sorter.Common.Models
{
    public class Name : IName
    {
        public string FirstNames { get; set; }
        public string LastName { get; set; }
    }
}
