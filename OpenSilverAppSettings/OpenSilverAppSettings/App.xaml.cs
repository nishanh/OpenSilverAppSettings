using System.Windows;
using Microsoft.Extensions.Configuration;

namespace OpenSilverAppSettings
{
    public sealed partial class App : Application
    {
        // Invoked by Browser project
        public App(IConfiguration configuration)
        {
            InitApplication(configuration);
        }

        // Invoked by Simulator project (which only supports a parameterless constructor)
        public App()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            InitApplication(configuration);
        }

        private void InitApplication(IConfiguration configuration)
        {
            this.InitializeComponent();

            var mainPage = new MainPage(configuration);
            Window.Current.Content = mainPage;
        }
    }
}
