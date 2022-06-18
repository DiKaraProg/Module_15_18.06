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
using Library_Module_13_OOP;

namespace MOdule13_OOP
{
    /// <summary>
    /// Логика взаимодействия для EventLog_Window.xaml
    /// </summary>
    public partial class EventLog_Window : Window
    {
        public EventLog_Window()
        {
            InitializeComponent();
            ListEvent.ItemsSource = Bank_A.Events;
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
