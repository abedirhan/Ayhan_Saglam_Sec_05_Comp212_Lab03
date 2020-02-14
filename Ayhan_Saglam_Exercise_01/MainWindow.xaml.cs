using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

namespace Ayhan_Saglam_Exercise_01
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _patientName;
        private string _patientAdress;
        private double _value;





        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
