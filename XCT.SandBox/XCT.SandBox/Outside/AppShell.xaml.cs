using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace App7
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
		}

		//protected override async void OnNavigated(ShellNavigatedEventArgs args)
		//{
		//	base.OnNavigated(args);

		//	string url = "//tabbar/About";
		//	var absolute = args.Current.Location.ToString();

		//	if (absolute.Contains(url))
		//		await Shell.Current.CurrentPage.DisplayToastAsync(string.Empty);

		//}
	}
}
