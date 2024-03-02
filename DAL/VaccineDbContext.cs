using System.Data.Entity;

namespace DAL
{
    public class VaccineDbContext: DbContext
    {
        public VaccineDbContext() : base("name = Vaccine")
        {
            Database.SetInitializer<VaccineDbContext>(new DropCreateDatabaseIfModelChanges<VaccineDbContext>());
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
    public class DALContextInit : DropCreateDatabaseIfModelChanges<VaccineDbContext>
    {
        protected override void Seed(VaccineDbContext context)
        {
            context.Users.Add(new User { });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}
