using LegalLand.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LegalLand.Views
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