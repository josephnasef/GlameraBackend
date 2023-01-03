using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
   public interface ICategoryService
    {
        Task<List<CategoryDTO>> List();
        Task<List<CategoryDTO>> ListForUser(string UserId);
        Task<bool> Create(CategoryDTO entity);
        Task<CategoryDTO> Update(int Id, CategoryDTO entity);
        Task<CategoryDTO> Delete(int Id);
    }
}
