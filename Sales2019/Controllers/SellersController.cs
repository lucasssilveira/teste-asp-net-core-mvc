using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sales2019.Services;

namespace Sales2019.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }


        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        } 
    }
}