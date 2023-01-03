using Glamera.Domin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Repository.Abstraction
{
    public interface IBillRepo
    {
        Task<Bill> AddAsync(Bill entity);
        Task<Bill> GetByAsync(params object[] Id);
        IEnumerable<Bill> GetAll();
        Task<IEnumerable<Bill>> GetAllAsyn();
        Bill Update(Bill entity);
        Task<Bill> UpdateAsync(Bill entity);
        Bill Remove(Bill entity);
        Task<Bill> RemoveByIdAsync(params object[] Id);
        Bill RemoveById(params object[] Id);
    }
}
