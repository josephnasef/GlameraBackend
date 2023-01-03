using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.DTO.DTOs
{
    public class ItemBranchDTO
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ItemId { get; set; }
        public BranchDTO branch { get; set; }
        public ItemDTO item { get; set; }
        public ICollection<BillDTO> bills { get; set; }
    }
}
