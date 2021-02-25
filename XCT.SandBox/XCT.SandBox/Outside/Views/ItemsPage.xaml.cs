using App7.ViewModels;
using Xamarin.Forms;

namespace App7.Views
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = new ItemsViewModel();
        }
    }
}