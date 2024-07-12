using Project.Net8;

namespace QuanLyKhuCongNghiep;

public class Program
{
    public static void Main(string[] args)
    {
        //     Tinify.Key = DefaultKey.KEY_TINIFY;


        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}