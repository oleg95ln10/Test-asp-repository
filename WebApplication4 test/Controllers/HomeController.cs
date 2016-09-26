﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4_test.Models;

namespace WebApplication4_test.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
        public ViewResult AutoProperty()
        {
            // создается новый объект Product
            Product myProduct = new Product();
            // устанавливается значение свойства
            myProduct.Name = "Kayak";
            // читается свойство
            string productName = myProduct.Name;
            // генерируется представление
            return View("Result",
            (object)String.Format("Product name: {0}", productName));
        }
    }
}