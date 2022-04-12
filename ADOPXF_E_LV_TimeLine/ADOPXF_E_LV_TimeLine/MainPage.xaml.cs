using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ADOPXF_E_LV_TimeLine
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = DataFactory.Classes;
        }
        private async void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (Models.ExerciseClass) timelineListView.SelectedItem;
            await DisplayAlert($"{ item.ClassTime:t}", $"{item.ClassName} with {item.Instructor}", "Yeaah!!");

            timelineListView.SelectedItem = null;
        }
    }
}
