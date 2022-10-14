using TE_CFA.Models;
using Microsoft.EntityFrameworkCore;

namespace TE_CFA.Data
{
    public class TraineeDbContext : DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }

        public DbSet<Trainee> Trainees { get; set; }

    }
}
