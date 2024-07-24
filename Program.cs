using System.Net;

namespace WebHello2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/api/cars", async context =>
                {
                    await context.Response.WriteAsJsonAsync(Car.Cars);
                });
                endpoints.MapGet("/api/car/{id:int}", async (HttpContext context, int id) =>
                {
                    var car = Car.Cars.FirstOrDefault(car => car.Id == id);
                    if (car != null)
                        await context.Response.WriteAsJsonAsync(car);
                    else
                        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                });
            });

            app.Run();
        }
    }
}
