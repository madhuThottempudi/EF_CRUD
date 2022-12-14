using EmployeeData.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var ctx = new EmployeeDbContext())
            //{
            //    var emp = new EnsurityEmployee() { Id = 12, Name = "vishnuvardhan", Address = "tatatcs" };
            //    var emp = new EnsurityEmployee();
            //    ctx.Employees.Add(emp);
            //    ctx.SaveChanges();
            //}

            //using (var data = new EmployeeDbContext())
            //{
            //    var stu_data = new Student();
            //    data.Students.Add(stu_data);
            //    data.SaveChanges();
            //}

            


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
