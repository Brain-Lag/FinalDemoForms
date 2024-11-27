using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDemoForms.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public bool Authenticate(string login, string password)
        {
            var user = _context.Master.FirstOrDefault(u => u.MasterLogin == login && u.MasterPassword == password);
            return user != null;
        }
    }
}
