using Glamera.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Abstraction
{
    public interface IitemRepo
    {
        Task<Item> AddAsync(Item entity);
        Task<Item> GetByAsync(params object[] Id);
        IEnumerable<Item> GetAll();
        Task<IEnumerable<Item>> GetAllAsyn();
        Item Update(Item entity);
        Task<Item> UpdateAsync(Item entity);
        Item Remove(Item entity);
        Task<Item> RemoveByIdAsync(params object[] Id);      
        Item RemoveById(params object[] Id);
    }
}
