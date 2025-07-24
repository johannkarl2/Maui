namespace Portrias_maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new Setting());
           return new Window(new AppShell());

        }
    }
}