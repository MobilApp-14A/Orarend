using Orarend.Pages;

namespace Orarend;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("orarendHozzaadasa", typeof(OrarendHozzaadasa));
    }
}
