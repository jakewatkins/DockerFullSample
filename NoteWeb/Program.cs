using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Notebook.Model;

namespace NoteWeb
{
    public class Program
    {
        private static void InitDb()
        {
            NoteDbContext context = new NoteDbContext();

            if (false == context.Database.EnsureCreated() )
            {
                SetupDb setupDb = new SetupDb(context);
                setupDb.Setup();
            }
        }

        public static void Main(string[] args)
        {
            
            InitDb();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
