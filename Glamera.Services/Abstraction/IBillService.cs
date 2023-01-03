using Glamera.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Services.Abstraction
{
    public interface IBillService
    {
        Task<List<BillDTO>> List();
        Task<bool> Create(BillDTO entity);
        Task<BillDTO> Update(int Id, BillDTO entity);
        Task<BillDTO> Delete(int Id);
    }
}
