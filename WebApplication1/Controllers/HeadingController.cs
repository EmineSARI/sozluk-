using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager ch = new CategoryManager(new EFCategoryDal());

        public ActionResult Index()
        {
            var headingvalues = hm.GetCategoryList();
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in ch.GetCategoryList()
                                                  select new SelectListItem
                                                  {Text=x.CategotyName,
                                                  Value=x.CategoryID.ToString()

                                                  }
                                                  ).ToList();
            ViewBag.vlc = valuecategory;
            return View();
                                               
          
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
             p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

    }
}