using ATM.DataBase;
namespace ATM.Function;
public class Program
{
    public static void Main()
    {
        try
        {
            
            Console.Title = "Bankomat Dasturi";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DataBaseConnection.ConnectDB();
            ProgramMain.Main_atm();
        }
        catch (Exception)
        {
            Main();
        }

    }
}
