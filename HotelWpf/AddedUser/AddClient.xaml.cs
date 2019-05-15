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

namespace HotelWpf
{
   
    public partial class AddClient : Window
    {
        public AddClient()
        {
            //Hotel hotel;
            InitializeComponent();
            using (Service1Client client = new Service1Client())
            {
            
                string[] hotels = client.GetHotelName();
                    foreach (var item in hotels)
                    {
                        cbHotel.Items.Add(item);
                    }
                cbHotel.SelectedIndex = 0;
            
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           using (Service1Client client = new Service1Client())
           {
          var child=client.GetApartaments(dpFirst.SelectedDate.Value, dpSecond.SelectedDate.Value, cbHotel.SelectedItem.ToString());
                foreach (var item in child)
                {
                    spBtn.Children.Add(new Button() { Content = item.Numb.ToString() });
                }
           }
        }
    }
}
