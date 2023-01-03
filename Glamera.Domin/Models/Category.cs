using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Models
{
    public class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Item> Items { get; set; }

        
    }
}
