using System.ComponentModel;
using Xamarin.Forms;
using XamarinTests.ViewModels;

namespace XamarinTests.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}