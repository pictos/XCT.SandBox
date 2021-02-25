using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace App7.ViewModels
{
    public class ItemsViewModel
    {
        public ICommand ButtonClickedCommand { get; }

        public ItemsViewModel()
        {
            ButtonClickedCommand = new AsyncCommand(Button_Clicked);
        }

        private async Task Button_Clicked()
        {
            await Shell.Current.GoToAsync("//tabbar/About");
			try
			{
				await Task.Delay(1);
				await Shell.Current.CurrentPage.DisplayToastAsync(string.Empty);
			}
			catch (Exception ex)
			{
				await Shell.Current.CurrentPage.DisplayAlert("Error", ex.ToString(), "Ok");
			}
		}
    }
}
