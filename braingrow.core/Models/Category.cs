using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace braingrow.Core
{
  public class Category
  {
    public string Name { get; set; }

    public string Description{ get; set; }

    public virtual Category Parent { get; set; }
  }
}
