using Microsoft.EntityFrameworkCore;

namespace PracticeAspDotNet.Database
{
    public class DataBContext :DbContext
    {
    public DataBContext(DbContextOptions<DataBContext> options) :base (options) { }
       

    public DbSet<Model.User> UserInfo { get; set; } 

    }
}
