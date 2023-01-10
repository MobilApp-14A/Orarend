using Orarend.Data;

namespace Orarend;

public partial class App : Application
{
    static Database database1;
    static Database database2;
    static Database database3;
    static Database database4;


    public static Database Orarend1
    {
        get
        {
            if (database1 == null)
            {
               database1 = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend1.db3"));
            }
            return database1;
        }
    }
    public static Database Orarend2
    {
        get
        {
            if (database2 == null)
            {
                database2 = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend2.db3"));
            }
            return database2;
        }
    }
    public static Database Orarend3
    {
        get
        {
            if (database3 == null)
            {
                database3 = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend3.db3"));
            }
            return database3;
        }
    }
    public static Database Orarend4
    {
        get
        {
            if (database4 == null)
            {
                database4 = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orarend4.db3"));
            }
            return database4;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
