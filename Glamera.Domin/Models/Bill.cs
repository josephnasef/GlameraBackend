using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class Bill
    {
        //By default, the primary key column of a table is implicitly backed by a clustered index, and all other indexes are non-clustered.
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int QYT { get; set; }
        public int ItemBranchId { get; set; }
        public ItemBranch itemBranch{ get; set; }
    }
}
