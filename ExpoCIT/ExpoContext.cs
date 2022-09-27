using Microsoft.EntityFrameworkCore;

namespace ExpoCIT
{
    public class ExpoContext : DbContext
    {
        public ExpoContext(DbContextOptions<ExpoContext> options) : base (options) { }


    }
}
