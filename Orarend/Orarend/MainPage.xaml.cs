using Orarend.Data;
using Orarend.Models;
using Orarend.Pages;

namespace Orarend;

public partial class MainPage : ContentPage
{
    public bool ures1 { get; set; }
    public bool ures2 { get; set; }
    public bool ures3 { get; set; }
    public bool ures4 { get; set; }
    public bool nemUres1 {
        get 
        {
            return !ures1;
        } 
    }
    public bool nemUres2
    {
        get
        {
            return !ures2;
        }
    }
    public bool nemUres3
    {
        get
        {
            return !ures3;
        }
    }
    public bool nemUres4
    {
        get
        {
            return !ures4;
        }
    }
    public MainPage()
	{
        ures1 = App.Orarend1.NapokKilistazasa().ToList().Count() == 0;
        ures2 = App.Orarend2.NapokKilistazasa().ToList().Count() == 0;
        ures3 = App.Orarend3.NapokKilistazasa().ToList().Count() == 0;
        ures4 = App.Orarend4.NapokKilistazasa().ToList().Count() == 0;
        InitializeComponent();
    }
    private void Button_Clicked1(object sender, EventArgs e)
    {

    }
    private void Button_Clicked2(object sender, EventArgs e)
    {

    }
    private void Button_Clicked3(object sender, EventArgs e)
    {

    }
    private void Button_Clicked4(object sender, EventArgs e)
    {

    }
    private async void NewBtn1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrarendHozzaadasa(1));
    }
    private async void NewBtn2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrarendHozzaadasa(2));
    }
    private async void NewBtn3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrarendHozzaadasa(3));
    }
    private async void NewBtn4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrarendHozzaadasa(4));
    }
}

