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
    /// <summary>
    /// Interaction logic for AddHotel.xaml
    /// </summary>
    public partial class AddHotel : Window
    {
        public AddHotel()
        {
            InitializeComponent();
            using (Service1Client client = new Service1Client())
            {
                List
        <Country> country = client.GetCountries().ToList();
                foreach (var item in country)
                {
                    cbContr.Items.Add(item.Name);
                }
            }
            cbContr.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> room = new List<int>();
            int amount;
            if(int.TryParse (tbAmount.Text,out amount))
            {
                for (int i = 0; i < amount; i++)
                {
                    room.Add(new int());
                }
            GenerateRoom generateRoom = new GenerateRoom(ref room);

                generateRoom.ShowDialog();
            }
            MessageBox.Show("Bulka");
        }
    }
}
