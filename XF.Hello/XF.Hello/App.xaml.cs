using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Hello.App_Code;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.Hello
{
	public partial class App : Application
	{
        public static Configuracao ConfigVM { get; set; }
        public App ()
		{
			InitializeComponent();

            if (ConfigVM == null) ConfigVM = new Configuracao();

			MainPage = new NavigationPage(new MainPage()); //incluir essa linha
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
