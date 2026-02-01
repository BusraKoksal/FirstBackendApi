using FirstBackendApi.Data;
using FirstBackendApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstBackendApi.Services
{
    public class HomeService:IHomeService
    {
        private readonly AppDbContext _context;
        public HomeService(AppDbContext context)
        {
            _context = context;
        }
        public Home Create(string name)
        {
            var home = new Home
            {
                Name = name,
                CreatedAt = DateTime.UtcNow
            };
            _context.Homes.Add(home);
            _context.SaveChanges();
            return home;
        

      
        }
    }
}
