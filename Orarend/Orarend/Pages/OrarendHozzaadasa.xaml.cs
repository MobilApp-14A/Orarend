using Microsoft.Maui.Graphics.Text;
using Orarend.Models;

namespace Orarend.Pages;

public partial class OrarendHozzaadasa : ContentPage
{
	public List<string> napokNeve { get; set; } = new List<string>() 
	{ 
		"Hétfő",
		"Kedd",
		"Szerda",
		"Csütörtök",
		"Péntek"
	};
    public List<Nap> napok { get; set; } = new List<Nap>();
    public List<string> entrykTextje { get; set; } = new List<string>();
    public bool mentheto { get; set; }
    public IView[] childrens;
    public string nap { get; set; } = "Hétfő";
	public OrarendHozzaadasa()
	{
		InitializeComponent();
		childrens = new IView[orarend.Children.Count()];
        orarend.Children.CopyTo(childrens, 0);
        mentheto = false;
    }

    private void SwipeGestureRecognizer_LeftSwiped(object sender, SwipedEventArgs e)
	{
        if(nap != "Péntek")
        {
            nap = napokNeve[napokNeve.IndexOf(nap) + 1];
            orarend.Children.Clear();
            foreach (var item in childrens)
            {
                orarend.Children.Add(item);
            }
            SearchAllEntry(orarend);

            List<Ora> orak = new();
            for (int i = 0; i < 9; i++)
            {
                orak.Add(new Ora
                {
                    oraTol = int.Parse(entrykTextje[0 + ( i * 7)]),
                    percTol = int.Parse(entrykTextje[1 + (i * 7)]),
                    oraIg = int.Parse(entrykTextje[2 + (i * 7)]),
                    percIg = int.Parse(entrykTextje[3 + (i * 7)]),
                    nev = entrykTextje[4 + (i * 7)],
                    terem = entrykTextje[5 + (i * 7)],
                    tanar = entrykTextje[6 + (i * 7)],
                });
            }

            napok.Add(new Nap
                {
                    orak=orak
                });

        }
        if (nap == "Csütörtök")
        {
            mentheto = true;
        }
    }

    private void SearchAllEntry(Layout layout)
    {
        foreach (var item in layout)
        {
            try
            {
                var temp = (Layout)item;
                SearchAllEntry(temp);
            }
            catch
            {
                var temp2 = new Entry();
                if (item.GetType() == temp2.GetType())
                {
                    var entry = (Entry)item;
                    entrykTextje.Add(entry.Text);
                }
            }
        }
    }

    private void SwipeGestureRecognizer_RightSwiped(object sender, SwipedEventArgs e)
    {
        if (nap != "Hétfő")
        {
            nap = napokNeve[napokNeve.IndexOf(nap) - 1];
            orarend.Children.Clear();
            foreach (var item in childrens)
            {
                orarend.Children.Add(item);
            }
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Orarend1.NapokHozzaadasa(napok);
    }
}