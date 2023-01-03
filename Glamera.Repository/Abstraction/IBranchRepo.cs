using Glamera.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Abstraction
{
    public interface IBranchRepo
    {
        Task<Branch> AddAsync(Branch entity);
        Task<Branch> GetByAsync(params object[] Id);
        IEnumerable<Branch> GetAll();
        Task<IEnumerable<Branch>> GetAllAsyn();
        Branch Update(Branch entity);
        Task<Branch> UpdateAsync(Branch entity);
        Branch Remove(Branch entity);
        Task<Branch> RemoveByIdAsync(params object[] Id);
        Branch RemoveById(params object[] Id);
    }
}
