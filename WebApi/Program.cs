using Application.Extensions;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Context;
using WebApi.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddApplicationServices();
        builder.Services.AddPersistenceServices(builder.Configuration);
        builder.Services.AddLibraryServices();
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())  
        {  
            try  
            {  
                var context = scope.ServiceProvider.GetService<RepositoryDBContext>();  
                context.Database.EnsureDeleted();  
                context.Database.Migrate();  
            }
            catch (Exception)  
            {  
                throw;  
            }  
        } 

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}