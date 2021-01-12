using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerServices;
        public SellersController(SellerService sellerService)
        {
            _sellerServices = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();
            return View(list);
        }
    }
}
