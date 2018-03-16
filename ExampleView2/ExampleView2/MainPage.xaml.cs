using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExampleView2
{

    public partial class MainPage : ContentPage
    {
        public List<Bag> tempdata;

        public MainPage()
        {
            InitializeComponent();
            GetBags();
            BagListView.ItemsSource = tempdata;
        }

        void GetBags()
        {
            tempdata = new List<Bag>
            {
                new Bag(){ BagName="Gucci Hand Bag Light Brown" , ShortDescription="Almost New", Price="3000.00 SAR", ImageURL="Bag1.png"},
                new Bag(){ BagName="Gucci er" , ShortDescription="Almost New", Price="3000.00 SAR", ImageURL="Bag2.png"},
                new Bag(){ BagName="Gucci Hand Bag Light Brown" , ShortDescription="Almost New", Price="3000.00 SAR", ImageURL="Bag3.png"}
            };

        }
        private async void OnBack(object sender, EventArgs e)
        {
            var result = await this.DisplayAlert("Exit page?", "Are you sure you want to exit this page? You will not be able to continue it.", "Yes", "No");
            if (result)
                await Navigation.PopModalAsync();
        }

        
        private  void SearchBar_TextChanged (object sender, TextChangedEventArgs e)
        {
            {
                //thats all you need to make a search  

                if (string.IsNullOrEmpty(e.NewTextValue))
                {
                    BagListView.ItemsSource = tempdata;
                }

                else
                {
                    BagListView.ItemsSource = tempdata.Where(x => x.BagName.ToLower().Contains(e.NewTextValue.ToLower()));
                }
            }
        }

    }

    }

