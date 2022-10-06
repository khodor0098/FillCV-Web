using CV_Project332.Model;
using Microsoft.EntityFrameworkCore;

namespace CV_Project332.Data
{
    public class DataClass : DbContext
    {
        public DataClass(DbContextOptions<DataClass> options) : base(options)
        {

        }

        public DbSet<informations> info { get; set; }
        public DbSet<Nationality> na { get; set; }

    }
}
