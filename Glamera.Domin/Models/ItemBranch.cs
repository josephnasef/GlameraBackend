using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class ItemBranch
    {
        public ItemBranch()
        {
            bills = new HashSet<Bill>();
        }
        [Key]
        public int Id { get; set; }
        public int BranchId { get; set; }
        public Branch branch { get; set; }
        public int ItemId { get; set; }
        public Item item { get; set; }
        public ICollection<Bill> bills { get; set; }

    }
}
