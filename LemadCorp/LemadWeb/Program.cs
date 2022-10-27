using LemadDb.Data;
using LemadDb.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LemadWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    var configuration = services.GetRequiredService<IConfiguration>();

                    using (SqlConnection connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                    {
                        foreach (Product item in context.Products.ToList())
                        {
                            if (item.Path != null && item.Photo == null)
                            {
                                string sqlQuery = @$"UPDATE Products SET Products.Photo = (SELECT BulkColumn FROM OPENROWSET(BULK N'{new FileInfo(item.Path).FullName}', SINGLE_BLOB) AS x) WHERE Products.Id = {item.Id}";
                                using (SqlCommand command = connection.CreateCommand())
                                {
                                    command.CommandText = sqlQuery;

                                    connection.Open();
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex) {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "Une erreur est survenue dans la BD.");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
