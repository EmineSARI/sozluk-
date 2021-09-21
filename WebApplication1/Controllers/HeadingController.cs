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
        WriterManager wm = new WriterManager(new EFWriterDal());

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
            List<SelectListItem> valuewriter=(from x in wm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text=x.WriterName + "" +x.WriterSurName,
                                                  Value=x.WriterID.ToString()

                                              }).ToList();
            ViewBag.vlc = valuecategory;
            ViewBag.vlw = valuewriter;
            return View();
                                               
          
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
             p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult ContentByHeading()
        {
            return View();
        }

    }
}