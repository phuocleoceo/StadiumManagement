using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class RentOrder
    {
        [Key]
        public int Id { get; set; }

        public double Deposit { get; set; }

        public int RentTime { get; set; }

        public Stadium Stadium { get; set; }

        public Bill Bill { get; set; }
    }
}
