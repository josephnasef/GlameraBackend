using Glamera.Domin.Context;
using Glamera.Domin.Models;
using Glamera.Repository.Abstraction;
using Glamera.Repository.Concert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Mangers
{
    public class BranchRepo : Repository<Branch>, IBranchRepo
    {
        public BranchRepo(GlameraContext MARIHUBtaskContext) : base(MARIHUBtaskContext)
        {
        }
    }
}
