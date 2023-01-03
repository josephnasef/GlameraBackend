using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
    public interface IBranchService
    {
        Task<BranchDTO> List();
        Task<bool> Create(BranchDTO entity);
        Task<BranchDTO> Update(int Id, BranchDTO entity);
        Task<BranchDTO> Delete(int Id);
    }
}
