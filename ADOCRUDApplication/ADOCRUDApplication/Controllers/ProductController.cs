using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADOCRUDApplication.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace ADOCRUDApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            DBOperations dBOperations = new DBOperations();
            return View(dBOperations.GetProducts());
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            DBOperations dBOperations = new DBOperations();
            var rowsAffected=dBOperations.AddProduct(product);
            if(rowsAffected > 0)
            {
                return RedirectToAction("Index","Product");
            }
            else
            {
                return Content("Internal Server Error");
            }
        }

        public IActionResult UpdateProduct(int productID)
        {
            DBOperations dBOperations = new DBOperations();
            var product = dBOperations.GetProductByID(productID);
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            DBOperations dBOperations = new DBOperations();
            var rowsAffected = dBOperations.UpdateProduct(product);

            if (rowsAffected > 0)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return Content("Internal Server Error");
            }
        }

        public IActionResult DeleteProduct(int productID)
        {
            DBOperations dBOperations = new DBOperations();
            var rowsAffected = dBOperations.DeleteProduct(productID);

            if (rowsAffected > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Internal Server Error");
            }
        }

        [HttpPost]
        public IActionResult Search(SearchProperties searchProperties)
        {
            DBOperations dBOperations = new DBOperations();
            var searchResult = dBOperations.Search(searchProperties);
            return View(searchResult);
        }

        public ActionResult DetailsProduct(int productID)
        {
            DBOperations dBOperations = new DBOperations();
            var product = dBOperations.GetProductByID(productID);
            return View(product);
        }
    }
}