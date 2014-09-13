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
    private IBrainGrowContext _context;

    public BrainGrow(IBrainGrowContext context)
    {
      _context = context;
    }

  }
}
