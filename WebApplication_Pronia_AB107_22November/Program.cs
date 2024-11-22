using Microsoft.EntityFrameworkCore;
using WebApplication_Pronia_AB107_22November.DAL;

namespace WebApplication_Pronia_AB107_22November
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer("server=;database=Pronia_task_Ab107;trusted_connection=true;Encrypt=false");
            }); 

            var app = builder.Build();



            app.MapControllerRoute(
                name:"defoult",
                pattern:"{controller=home}/{action=index}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
