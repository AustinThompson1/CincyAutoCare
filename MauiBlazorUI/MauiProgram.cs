using Microsoft.Extensions.Logging;
using CareCare.Data;
using Microsoft.EntityFrameworkCore;
namespace MauiBlazorUI;
using MudBlazor.Services;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddDbContext<CustomerContext>();
		builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddMudServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
