namespace Orarend;

public partial class MainPage : ContentPage
{
    public bool ures1 { get; set; } = false;
    public bool ures2 { get; set; } = true;
    public bool ures3 { get; set; } = true;
    public bool ures4 { get; set; } = true;
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
		InitializeComponent();
        this.BindingContext = this;
    }
}

