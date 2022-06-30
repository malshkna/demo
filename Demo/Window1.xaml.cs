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
using System.Windows.Shapes;

namespace Demo
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           
            fio.Text = App.FIO;
            role.Text = App.role;
            string firstName = "";

            for (int i = 0; i < App.FIO.Length; i++)
            {
                if (App.FIO[i] == ' ')
                {
                    break;
                }
                firstName += App.FIO[i];
            }
           image.Source = new BitmapImage(new Uri($"C:/Users/Skovo/source/repos/Demo/Demo/Images/{firstName}.jpeg"));

           
        }
    }
}
