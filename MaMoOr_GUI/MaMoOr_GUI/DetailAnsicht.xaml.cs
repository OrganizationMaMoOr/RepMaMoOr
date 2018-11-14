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

namespace MaMoOr_GUI
{
    /// <summary>
    /// Interaction logic for DetailAnsicht.xaml
    /// </summary>
    public partial class DetailAnsicht : Window
    {
        public DetailAnsicht()
        {
            InitializeComponent();
        }


        private void btn_detail_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btn_detail_downloadTasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_detail_downloadSampleSolution_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_detail_downloadAdditionalMaterial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_detail_uploadSampleSolution_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_detail_uploadAdditionalMaterial_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
