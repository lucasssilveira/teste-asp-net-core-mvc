using System;
using System.Collections.Generic;


namespace Sales2019.Models.ViewModels
{
    public class SellerFormViewModel
    {

        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
