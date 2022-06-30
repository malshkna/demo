using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.sqlConnection.Open();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.sqlConnection.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string query = $"SELECT * FROM Сотрудники WHERE Логин = '{login.Text}' AND Пароль = '{password.Text}' ";
            SqlCommand sqlCommand = new SqlCommand(query, App.sqlConnection);
            sqlCommand.ExecuteNonQuery();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    App.FIO = dataRow[3].ToString();
                    App.role = dataRow[2].ToString();
                }
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
