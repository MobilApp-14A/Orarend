namespace Orarend.Pages;

public partial class OrarendHozzaadasa : ContentPage
{
	public List<string> napok { get; set; } = new List<string>() 
	{ 
		"Hétfő",
		"Kedd",
		"Szerda",
		"Csütörtök",
		"Péntek"
	};
	public IView[] childrens;
    public string nap { get; set; } = "Hétfő";
	public OrarendHozzaadasa()
	{
		InitializeComponent();
		childrens = new IView[orarend.Children.Count()];
        orarend.Children.CopyTo(childrens, 0);
    }

	private void SwipeGestureRecognizer_LeftSwiped(object sender, SwipedEventArgs e)
	{
        if(nap != "Péntek")
        {
            nap = napok[napok.IndexOf(nap) + 1];
            orarend.Children.Clear();
            foreach (var item in childrens)
            {
                orarend.Children.Add(item);
            }
        }
    }
    private void SwipeGestureRecognizer_RightSwiped(object sender, SwipedEventArgs e)
    {
        if (nap != "Hétfő")
        {
            nap = napok[napok.IndexOf(nap) - 1];
            orarend.Children.Clear();
            foreach (var item in childrens)
            {
                orarend.Children.Add(item);
            }
        }

    }
}