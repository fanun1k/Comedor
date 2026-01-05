using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Model.Data;
using Model;
using FoodService;
using FoodService.Forms;

ApplicationConfiguration.Initialize();

var services = new ServiceCollection();

// Configuración
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

// DbContext
services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        configuration.GetConnectionString("DefaultConnection"),
        sql => sql.CommandTimeout(3)
    );
});
// Servicios
services.AddTransient<Cliente>();
services.AddTransient<item>();

// FORM (ESTO ES CLAVE)
services.AddTransient<Form1>();
services.AddTransient<SnackForm>();


// Build
using var provider = services.BuildServiceProvider();

// ARRANQUE CORRECTO
Application.Run(provider.GetRequiredService<SnackForm>());
