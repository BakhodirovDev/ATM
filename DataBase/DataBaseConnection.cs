using MySql.Data.MySqlClient;
namespace ATM.DataBase
{
    public class DataBaseConnection
    {
        // DataBase MYSQL
        static string connectionString = "Server=142.132.192.157;Database=x_u_10420_atm;User Id=x_u_10420_atm;Password=lX3wK2oI4l;";
        // Connection Sting 
        public static string ConnectionString()
        {
            return connectionString;
        }

        // Bazaga ulanish
        public static void ConnectDB()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM Users";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Close();
            }
            catch
            {
                DataBaseError.errorDB();
            }
        }

        //Bazadan Balansni olish
        public static double GetBalance()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string getBalanceQuery = "SELECT balance FROM Users WHERE id = 1";
            MySqlCommand getBalanceCmd = new MySqlCommand(getBalanceQuery, connection);
            return Convert.ToDouble(getBalanceCmd.ExecuteScalar());
        }

        // Parolni bazadan olish
        public static int GetPassWord()
        {
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string getPasswordQuery = "SELECT password FROM Users WHERE id = 1";
            MySqlCommand getPasswordCmd = new MySqlCommand(getPasswordQuery, connection);
            int Password = Convert.ToInt32(getPasswordCmd.ExecuteScalar());
            return Password;
        }

        // Balansni ayirish (Pul yechish)
        public static void CashOut(double pul)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string getBalanceQuery = "SELECT balance FROM Users WHERE id = 1";
            MySqlCommand getBalanceCmd = new MySqlCommand(getBalanceQuery, connection);
            double newBalance = Convert.ToDouble(getBalanceCmd.ExecuteScalar()) - pul;
            string updateBalanceQuery = $"UPDATE Users SET balance = {newBalance} WHERE id = 1";
            MySqlCommand updateBalanceCmd = new MySqlCommand(updateBalanceQuery, connection);
            updateBalanceCmd.ExecuteNonQuery();
        }

        public static int GetNumber()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string getPasswordQuery = "SELECT phone_number FROM Users WHERE id = 1";
            MySqlCommand getNumberCmd = new MySqlCommand(getPasswordQuery, connection);
            int Number = Convert.ToInt32(getNumberCmd.ExecuteScalar());
            return Number;
        }

        public static void NewNumberUpload(int number)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string updateNumberQuery = $"UPDATE Users SET phone_number = {number} WHERE id = 1";
            MySqlCommand updateBalanceCmd = new MySqlCommand(updateNumberQuery, connection);
            updateBalanceCmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void NewPasswordUpload(int pass)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string updateNumberQuery = $"UPDATE Users SET password = {pass} WHERE id = 1";
            MySqlCommand updateBalanceCmd = new MySqlCommand(updateNumberQuery, connection);
            updateBalanceCmd.ExecuteNonQuery();
            connection.Close();
        }


    }
}
