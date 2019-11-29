using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

namespace TaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbTM.ItemsSource = Process.GetProcesses();
        }

        private void KillProcess(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.GetProcesses()[lbTM.SelectedIndex].Kill();
            }
            catch (Win32Exception win)
            {
                MessageBox.Show(win.Message);
            }
        }
    }
}
