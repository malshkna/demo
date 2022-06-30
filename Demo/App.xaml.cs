using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using System.Data.SqlClient;

namespace Demo
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string FIO;
        public static string role;
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source = MARURU\SQLEXPRESS; Initial catalog = demo; Integrated security = true;");
        //Data Source = MARURU/SQLEXPRESS; Initial catalog = user12db; User id = user12; password = 123456;
    }
}
