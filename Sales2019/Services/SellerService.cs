using Sales2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales2019.Services
{
    public class SellerService
    {
        private readonly Sales2019Context _context;

        public SellerService(Sales2019Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
