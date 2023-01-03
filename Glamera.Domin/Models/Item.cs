using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class Item
    {
        public Item()
        {
            ItemBranchs = new HashSet<ItemBranch>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }    
        public string ItemCode { get; set; }
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public ICollection<ItemBranch> ItemBranchs { get; set; }
    }
}
