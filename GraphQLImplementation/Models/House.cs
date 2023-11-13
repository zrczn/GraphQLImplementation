using System.ComponentModel.DataAnnotations;

namespace GraphQLImplementation.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string Adress { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int LivingRooms { get; set; }
        public double MetersSquare { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
