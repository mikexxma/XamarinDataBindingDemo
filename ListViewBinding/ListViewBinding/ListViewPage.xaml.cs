using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListViewBinding
{
    public partial class ListViewPage : ContentPage
    {
  
        public ListViewPage()
        {
            ListViewDataManager.getListViewItems();
            InitializeComponent();
        }

        async void OnBtClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Button {    
                            Text = "button1"
                        },
                        new Button {
                           Text = "button2"
                        },
                        new Button {
                            Text = "button3"
                        }
                    }
                }
            });
        }
    }
}
