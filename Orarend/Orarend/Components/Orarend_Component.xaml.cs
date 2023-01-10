using Orarend.Data;
using Orarend.Models;
using System.Collections.ObjectModel;

namespace Orarend.Components;

public partial class Orarend_Component
{
	public string napokSzama { get; set; } = string.Empty;
	public Orarend_Component()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
    {
		Button s = (Button) sender;
		var index = FindHorizontalParent(s.Parent);

        Database[] orarendek = { App.Orarend1, App.Orarend2, App.Orarend3, App.Orarend4 };
		List<Nap> napok = orarendek[index+1].NapokKilistazasa().ToList();
		napokSzama = napok.Count().ToString();
	}

	public int FindHorizontalParent(object child)
	{
        Layout asd = (Layout) child;
        if (asd.Parent.GetType() == temp.GetType())
        {
            HorizontalStackLayout layout = (HorizontalStackLayout)asd.Parent;
            return int.Parse(layout.ClassId.ToString());
        }
        else
        {
            FindHorizontalParent(asd.Parent);
        }
        return -1;
    }
}