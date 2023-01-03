using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
    public interface IitemService
    {
        Task<List<ItemDTO>> List();
        Task<List<ItemDTO>> ListForUser(string UserId);
        Task<bool> Create(ItemDTO entity);
        Task<ItemDTO> Update(int Id, ItemDTO entity);
        Task<ItemDTO> Delete(int Id);
    }
}
