using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.DTO.DTOs
{
    public class ItemDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ItemCode { get; set; }

        public int CategoryId { get; set; }
        public CategoryDTO category { get; set; }

    }
}
