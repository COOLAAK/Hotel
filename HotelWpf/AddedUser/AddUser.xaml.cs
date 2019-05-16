using System.Windows;
using HotelWpf.ServiceNS;
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
