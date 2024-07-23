using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using KudosePOC.ViewModels;
using Plugin.Maui.SegmentedControl;
using KudosePOC.Views;

namespace KudosePOC
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSegmentedControl()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.ConfigureSyncfusionCore();
            builder.Services.AddTransient<Kudose>();
            builder.Services.AddTransient<SegmentedControlView>();
            builder.Services.AddTransient<KudosViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
