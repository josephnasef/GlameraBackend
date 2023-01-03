using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.DTO.DTOs
{
    public class BillDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int QYT { get; set; }
        public int ItemBranchId { get; set; }
    }
}
