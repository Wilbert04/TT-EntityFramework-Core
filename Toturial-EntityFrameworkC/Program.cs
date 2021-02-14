using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Toturial_EntityFrameworkC.DAL;
using Toturial_EntityFrameworkC.Models;

namespace Toturial_EntityFrameworkC
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var context = new SchoolContext();
            var studentsWithSameName = context.Students
                                              .Where(s => s.FirstName == GetName())
                                              .ToList();

        }

        public static string GetName()
        {
            return "Bill";
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
