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
      ViewBag.Message ="This website is an external extension of Lee's memory.  Lee's own memory is a faulty thing.  The write process seems to work ok, but the retrieval process seems to be very flaky.  So, what does one do when one's memory retrieval is faulty?  One dumps their memory to a web application like this one.  This web application's retrieval mechanism is MUCH more robust that Lee's, so Lee can now find things on this site YEARS after he has added them to his own memory (from which he probably can't retrieve them any more).";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Not sure why you would want or need to contact me, but just in case...";

      return View();
    }
  }
}