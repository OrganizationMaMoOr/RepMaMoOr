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
    /// Interaction logic for NewExercise.xaml
    /// </summary>
    public partial class NewExercise : Window
    {
        public NewExercise()
        {
            InitializeComponent();
        }

        private void btn_ne_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btn_ne_user_Click(object sender, RoutedEventArgs e)
        {
            AccountBearbeiten editAccount = new AccountBearbeiten();
            editAccount.Show();
            this.Close();
        }

        private void btn_ne_uploadTask_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ne_uploadAdditionalMaterial_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ne_sampleSolution_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ne_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ne_cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lb_ne_notVisible_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void tb_ne_titel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_description_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cb_ne_year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_ne_level_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_ne_tag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rtb_ne_writeTask_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
