using CS180619754.Models.Data;
using CS180619754.Models.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS180619754.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            //Declare list of PageVM
            List<PageVM> pagesList;
            
            //using statement closes down connection
            using (Db db =new Db())
            {
                //Initialize the list
                pagesList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }
            //Return view with list
            return View(pagesList);

            public ActionResult AddPage()
            {
                return View();
            }
        }
    }
}