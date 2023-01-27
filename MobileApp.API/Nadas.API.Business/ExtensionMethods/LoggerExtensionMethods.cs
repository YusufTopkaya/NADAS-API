using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Business.ExtensionMethods
{
    public static class LoggerExtensionMethods
    {
        private static readonly string _logTemplate = "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}";
        private static Serilog.ILogger SerilogInit(string applicationName)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("Application", applicationName)
                .Enrich.FromLogContext()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore.Authentication", LogEventLevel.Information)
                .WriteTo.Debug(outputTemplate: DateTime.Now.ToString())
                .WriteTo.Console(outputTemplate: _logTemplate, theme: AnsiConsoleTheme.Literate)
                .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day, outputTemplate: _logTemplate)
                .CreateLogger();
            return Log.Logger;
        }

        public static IHostBuilder AddCustomSerilog(this IHostBuilder builder, string applicationName)
        {
            return builder.ConfigureLogging(config =>
            {
                config.ClearProviders();
                config.AddSerilog(SerilogInit(applicationName));
            }).UseSerilog();
        }
    }
}
