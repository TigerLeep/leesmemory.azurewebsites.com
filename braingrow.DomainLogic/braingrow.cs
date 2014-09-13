using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using braingrow.Core;
using braingrow.Data;

namespace braingrow.DomainLogic
{
  public class BrainGrow : IBrainGrow
  {
    private IBrainGrowContext _context = new BrainGrowContext();

    public BrainGrow()
    {
    }

    public List<Category> GetCategories(string parentCategoryName)
    {
      List<Category> categories = null;
      if (parentCategoryName == null)
      {
        categories = _context.Categories.Where(c => c.Parent == null)
                                        .ToList();
      }
      else
      {
        categories = _context.Categories.Where(c => c.Parent != null
                                                    && c.Parent.Name.ToLower() == parentCategoryName.ToLower())
                                        .ToList();
      }
      return categories;
    }

    public Category GetCategoryByName(string categoryName)
    {
      categoryName = categoryName ?? "";
      return _context.Categories.Where(c => c.Name.ToLower() == categoryName.ToLower()).FirstOrDefault();
    }

    public List<Resource> GetResources(string categoryName)
    {
      if(categoryName == null)
      {
        return new List<Resource>();
      }
      var resourceQuery = _context.Resources.Where(r => r.Category.Name.ToLower() == categoryName.ToLower());
      return resourceQuery.ToList();
    }

  }
}
