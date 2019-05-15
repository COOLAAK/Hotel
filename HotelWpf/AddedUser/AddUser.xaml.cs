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
using HotelWpf.ServiceReference1;

namespace HotelWpf.AddedUser
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Name = tbName.Text;
            user.Phone = tbPhone.Text;
            user.Surname = tbSurName.Text;
            user.Email = tbEmail.Text;
        }
    }
}
