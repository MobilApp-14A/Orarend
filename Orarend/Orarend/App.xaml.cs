using Orarend.Data;

namespace Orarend;

public partial class App : Application
{
    static Database database;


    public static Database Orarend1
    {
        get
        {
            if (database == null)
            {
               database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend1.db3"));
            }
            return database;
        }
    }
    public static Database Orarend2
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend2.db3"));
            }
            return database;
        }
    }
    public static Database Orarend3
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend3.db3"));
            }
            return database;
        }
    }
    public static Database Orarend4
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend4.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
