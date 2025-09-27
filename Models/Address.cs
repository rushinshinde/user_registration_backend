using System.ComponentModel.DataAnnotations;

namespace ClientManagementBackend.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
