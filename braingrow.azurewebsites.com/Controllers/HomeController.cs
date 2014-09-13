using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using braingrow.DomainLogic;
using braingrow.Core;

namespace braingrow.azurewebsites.com.Controllers
{
  public class HomeController : Controller
  {

    private BrainGrow _brainGrow = new BrainGrow();

    public ActionResult Index(string categoryName)
    {
      categoryName = categoryName ?? "";
      Category category = _brainGrow.GetCategoryByName(categoryName);
      ViewBag.Category = category;
      ViewBag.SubCategories = _brainGrow.GetCategories(category == null ? null : category.Name);
      ViewBag.Resources = _brainGrow.GetResources(category == null ? null : category.Name);
      return View();
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