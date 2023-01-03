using Glamera.Domin.Context;
using Glamera.Domin.Models;
using Glamera.Repository.Abstraction;
using Glamera.Repository.Concert;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Mangers
{
    public class ItemBranchRepo : Repository<ItemBranch>, IitemBranchRepo
    {
        public ItemBranchRepo(GlameraContext MARIHUBtaskContext) : base(MARIHUBtaskContext)
        {
        }

        public IQueryable<ItemBranch> GetAllEgarLoading()
        {
           var tr =  this.GetAllQurAsync().Include(s => s.bills).Include(s => s.item).ThenInclude(s =>s.category).Include(w => w.branch);
            return tr;
        }
    }
}
