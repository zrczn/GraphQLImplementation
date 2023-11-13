using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace GraphQLImplementation.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
