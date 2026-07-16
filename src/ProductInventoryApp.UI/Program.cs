using Microsoft.Extensions.DependencyInjection;
using ProductInventoryApp.Application;
using ProductInventoryApp.Infrastructure;

namespace ProductInventoryApp.UI;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection();
        services.AddSingleton<IProductRepository, InMemoryProductRepository>();
        services.AddSingleton<IProductService, ProductService>();
        services.AddSingleton<MainForm>();
        services.AddSingleton<IMainView>(sp => sp.GetRequiredService<MainForm>());
        services.AddSingleton<MainPresenter>();

        using var provider = services.BuildServiceProvider();

        var presenter = provider.GetRequiredService<MainPresenter>();
        presenter.Initialize();

        var mainForm = provider.GetRequiredService<MainForm>();
        System.Windows.Forms.Application.Run(mainForm);
    }
}
