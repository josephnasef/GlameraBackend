using Glamera.Domin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glamera.Domin.Context
{
    public class GlameraContext : IdentityDbContext
    {
        public GlameraContext(DbContextOptions<GlameraContext> options)
         : base(options)
        {
        }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<ItemBranch> ItemBranchs { get; set; }
    }
}
