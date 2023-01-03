using Glamera.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Abstraction
{
    public interface ICategoryRepo
    {
        Task<Category> AddAsync(Category entity);
        Task<Category> GetByAsync(params object[] Id);
        IEnumerable<Category> GetAll();
        Task<IEnumerable<Category>> GetAllAsyn();
        Category Update(Category entity);
        Task<Category> UpdateAsync(Category entity);
        Category Remove(Category entity);
        Task<Category> RemoveByIdAsync(params object[] Id);
        Category RemoveById(params object[] Id);
    }
}
