using BuiChiCuong.Context;
using BuiChiCuong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiChiCuong.Controllers
{
    public class HomeController : Controller
    {
        dbModelDataContext obj = new dbModelDataContext();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.listCategory = obj.Categories.ToList();
            objHomeModel.listProduct = obj.Products.ToList();
            return View(objHomeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}