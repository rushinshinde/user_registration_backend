using ClientManagementBackend.DTOs;
using ClientManagementBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementBackend.Services
{
    public class ClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }

        public List<Client> GetClients()
        {
            return _context.Clients.Include(c => c.Addresses).ToList();
        }

        public Client AddClient(ClientDto dto)
        {
            var client = new Client
            {
                Title = dto.Title,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                DOB = dto.DOB,
                Addresses = dto.Addresses.Select(a => new Address
                {
                    AddressLine1 = a.AddressLine1,
                    Town = a.Town,
                    City = a.City,
                    Pincode = a.Pincode
                }).ToList()
            };

            _context.Clients.Add(client);
            _context.SaveChanges();
            return client;
        }
    }
}
