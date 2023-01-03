using Glamera.DTO.DTOs;
using Glamera.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
    public interface IitemBranchService
    {
        List<GroubedList> List();
        Task<List<ItemBranchDTO>> ListForUser(string UserId);
        Task<bool> Create(ItemBranchDTO entity);
        Task<ItemBranchDTO> Update(int Id, ItemBranchDTO entity);
        Task<ItemBranchDTO> Delete(int Id);
    }
}
