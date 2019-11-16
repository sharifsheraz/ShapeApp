using System.Data.Entity;
using ShapeApp.Models;

namespace ShapeApp.DbContext
{
    public class ApplicationDbContext:System.Data.Entity.DbContext
    {
        public ApplicationDbContext():base("DefaultConnection")
        {

        }
        public virtual DbSet<User> Users { get; set; }
    }
}