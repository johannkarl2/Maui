using System.Threading.Tasks;

namespace Portrias_maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogInClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Setting());

        }
        public async Task OnClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new Setting());

        }
    }
}
