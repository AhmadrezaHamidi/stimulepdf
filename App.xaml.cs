using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VstaabnerWpf.Infra;

namespace VstaabnerWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            var services = new ServiceCollection();

            services.AddDbContext<MyDbContext>(options =>
            {
                options.UseSqlServer("Server = .; Database=VestaAbnerDataBAseNew;Integrated Security = true;");
            });

        }
    }
}
