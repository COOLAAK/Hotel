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
    /// Interaction logic for GenerateRoom.xaml
    /// </summary>
    public partial class GenerateRoom : Window
    {
        Apartament apartament;
       List< TypeApartment> typeApartments;
        public GenerateRoom(ref Apartament apartament)
        {
            InitializeComponent();
            this.apartament = apartament;
            using (Service1Client client = new Service1Client())
            {

                typeApartments = client.GetTypeApartments().ToList();
                foreach (var item in typeApartments)
                {
                    cbTypeApart.Items.Add(item.Type);

                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            apartament.Price = int.Parse(tbPrice.Text);
            apartament.CountRoom = int.Parse(tbRoom.Text);
            apartament.PlaceCount = int.Parse(tbLie.Text);
            apartament.Floor = int.Parse(tbFloor.Text);
            apartament.TypeApartment = new TypeApartment() { Type = cbTypeApart.SelectedItem.ToString() };
            this.Close();
        }
    }
}   
