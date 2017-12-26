using Microsoft.EntityFrameworkCore;

namespace dotnetAng.Persistence
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
          : base(options)
        {
        }
    }
}






        