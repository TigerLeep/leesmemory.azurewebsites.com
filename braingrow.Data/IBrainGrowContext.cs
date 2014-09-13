using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using braingrow.Core;

namespace braingrow.Data
{
  public interface IBrainGrowContext
  {
    List<Category> Categories { get; set; }
    List<Resource> Resources { get; set; }
  }
}
