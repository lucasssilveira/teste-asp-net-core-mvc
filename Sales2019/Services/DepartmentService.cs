using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales2019.Models;

namespace Sales2019.Services
{
    public class DepartmentService
    {

        private readonly Sales2019Context _context;

        public DepartmentService(Sales2019Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
