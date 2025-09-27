using System;
using System.Collections.Generic;

namespace ClientManagementBackend.DTOs
{
    public class ClientDto
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public List<AddressDto> Addresses { get; set; }
    }

    public class AddressDto
    {
        public string AddressLine1 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
