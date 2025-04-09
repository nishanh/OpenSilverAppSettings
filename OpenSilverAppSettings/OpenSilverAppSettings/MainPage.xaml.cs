using System.ComponentModel;
using System.Windows.Controls;
using Microsoft.Extensions.Configuration;

namespace OpenSilverAppSettings
{
    public partial class MainPage : Page, INotifyPropertyChanged
    {
        public string Message { get; set; }

        public MainPage(IConfiguration configuration)
        {
            this.InitializeComponent();

            DataContext = this;
            Message = configuration?["message"] ?? "Can not load configuration";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
