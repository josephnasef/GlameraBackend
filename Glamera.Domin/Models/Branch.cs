using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class Branch
    {
        public Branch()
        {
            ItemBranchs = new HashSet<ItemBranch>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ItemBranch> ItemBranchs { get; set; }

    }
}
