using Microsoft.Extensions.Logging;
using ProsperDaily.Repositories;
using Syncfusion.Maui.Core.Hosting;
using System.Transactions;
using ProsperDaily.MVVM.Model;
namespace ProsperDaily
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Black.ttf", "Strong");
                    fonts.AddFont("LibreFranklin-Regular.ttf", "Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<BaseRepository<Transactions>>();
            return builder.Build();
        }
    }
}
