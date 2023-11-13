using System.ComponentModel.DataAnnotations;

namespace GraphQLImplementation.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int Ammount { get; set; }
        public DateTime TransactionDate { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }


        public int HouseId { get; set; }
        public House House { get; set; }


        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
    }
}
