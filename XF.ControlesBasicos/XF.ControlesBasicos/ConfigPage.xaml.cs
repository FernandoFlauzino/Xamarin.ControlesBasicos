using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConfigPage : ContentPage
	{
		public ConfigPage ()
		{
			InitializeComponent ();
		}

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = (SwitchCell)sender;
            bool switchCellState = switchCell.On;

            if (switchCellState)
            {
                txtEmail.IsVisible = true;
            }  
            else
            {
                txtEmail.IsVisible = false;
                txtEmail.Text = string.Empty;
            }
        }
    }
}