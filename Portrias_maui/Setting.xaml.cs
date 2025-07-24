namespace Portrias_maui;

public partial class Setting : ContentPage
{
	public Setting()
	{
		InitializeComponent();
	}
    
         private async void LogOutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }
}