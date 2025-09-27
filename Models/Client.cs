using System.ComponentModel.DataAnnotations;

namespace ClientManagementBackend.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Gender { get; set; }
        public DateTime? DOB { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
