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
    /// Interaction logic for AccountBearbeiten.xaml
    /// </summary>
    public partial class AccountBearbeiten : Window
    {
        public AccountBearbeiten()
        {
            InitializeComponent();
        }



        private void btn_ea_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btn_ea_editPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ea_saveNewPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ea_cancelEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_ea_saveEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tb_ea_firstname_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_ea_lastname_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_ea_email_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_ea_oldPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_ea_newPassword1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_ea_newPassword2_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
