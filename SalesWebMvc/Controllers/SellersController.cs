using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] //Notation to define that the action is a Post request.
        [AutoValidateAntiforgeryToken] //Prevent attack in your session from others
        public IActionResult Create(Seller seller)
        {
            _sellerServices.Insert(seller);
           return RedirectToAction(nameof (Index));
        }
    }
}
