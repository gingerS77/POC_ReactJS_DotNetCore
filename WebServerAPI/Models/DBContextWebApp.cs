using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Windows.Management.Deployment.Preview;

namespace WebServerAPI.Models
{
    public class DBContextWebApp : DbContext
    {
        public DBContextWebApp(DbContextOptions<DBContextWebApp> options):base(options)
        {

        }
        // Purpose: List<string> to make this understandable to Entity framework, it will allow to make the 
        // serilization and deserializing that object.
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Student>().Property(p=>p.Subjects).HasConversion(v=>JsonConvert.SerializeObject(v),v=>)
        }
        public virtual DbSet<Student> Students { get; set; }
    }
}
