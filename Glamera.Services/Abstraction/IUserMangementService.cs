using Glamera.Domin.Models;
using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
    public interface IUserMangementService
    {
        Task<List<ApplicationUserDTO>> ListUser ();      
        Task<bool>CreateUser (ApplicationUserDTO entity);
        Task<RegistrationResponseDTO> Login (ApplicationUserDTO entity);
        Task<ApplicationUserDTO> UpdateUser (int Id, ApplicationUserDTO entity);
        Task<ApplicationUserDTO> DeleteUser (int Id);
        Task<ApplicationUser> GetById(string id);

    }
}
