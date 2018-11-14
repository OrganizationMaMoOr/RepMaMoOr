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

namespace MaMoOr_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_main_search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_main_user_Click(object sender, RoutedEventArgs e)
        {
            AccountBearbeiten editAccount = new AccountBearbeiten();
            editAccount.Show();
            this.Close();
        }

        private void btn_main_add_Click(object sender, RoutedEventArgs e)
        {
            NewExercise newExrcise = new NewExercise();
            newExrcise.Show();
            this.Close();
        }

        private void tb_main_filter_titel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_main_filter_author_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cb_main_filter_year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_main_filter_level_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_main_filter_tags_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dp_main_filter_date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
