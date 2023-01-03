using Glamera.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Abstraction
{
    public interface IitemBranchRepo
    {
        Task<ItemBranch> AddAsync(ItemBranch entity);
        Task<ItemBranch> GetByAsync(params object[] Id);
        IEnumerable<ItemBranch> GetAll();
        Task<IEnumerable<ItemBranch>> GetAllAsyn();
        IQueryable<ItemBranch> GetAllQurAsync();
        IQueryable<ItemBranch> GetAllEgarLoading();
        ItemBranch Update(ItemBranch entity);
        Task<ItemBranch> UpdateAsync(ItemBranch entity);
        ItemBranch Remove(ItemBranch entity);
        Task<ItemBranch> RemoveByIdAsync(params object[] Id);
        ItemBranch RemoveById(params object[] Id);
    }
}
