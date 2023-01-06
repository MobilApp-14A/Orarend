using Orarend.Pages;

namespace Orarend.Components;

public partial class UjOrarend_Component
{
	public UjOrarend_Component()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new OrarendHozzaadasa());
    }
}