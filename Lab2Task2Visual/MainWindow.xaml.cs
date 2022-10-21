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

namespace Lab2Task2Visual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int slRValue;
        int slGValue;
        int slBValue;
        

        public MainWindow()
        {
            InitializeComponent();

            this.UC2.MouseMove += new MouseEventHandler(Update);
            
        }
        
        public void SlValue (object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.slRValue = (int)this.UC2.GetValueR();
        }

        private void UserControl2_Loaded(object sender, RoutedEventArgs e)
        {
            this.slRValue = (int)this.UC2.GetValueR();
            this.label1.Content = slRValue.ToString();        
        }

        private void Update(object sender, EventArgs e)
        {
            this.slRValue = (int)this.UC2.GetValueR();
            this.label1.Content = "Red: " + slRValue.ToString();
            this.slGValue = (int)this.UC2.GetValueG();
            this.label2.Content = "Green: " + slGValue.ToString();
            this.slBValue = (int)this.UC2.GetValueB();
            this.label3.Content = "Blue: " + slBValue.ToString();
        }
    }
}
