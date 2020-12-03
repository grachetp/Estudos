using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            if(count <= 1)
            {
                ((Button)sender).Text = $"Eu te amo {count} vez.";
            }
            else
            {
                ((Button)sender).Text = $"Eu te amo {count} vezes.";
            }
            
        }
    }
}
