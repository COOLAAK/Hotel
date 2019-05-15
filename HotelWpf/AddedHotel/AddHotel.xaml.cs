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
                List<Country> country = client.GetCountries().ToList();
                foreach (var item in country)
                {
                    cbContr.Items.Add(item.Name);
                }
            }
            cbContr.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int amount;
            int Numb = 1;
            if (int.TryParse(tbAmount.Text, out amount))
            {
                spRoom.Children.Clear();
                for (int j = 0; j < amount / 20; j++)
                {

                    Grid AddRoom = new Grid();
                    AddRoom.Margin = new Thickness(0, 5, 0, 0);
                    for (int i = 0; i < 20; i++)
                    {
                        AddRoom.ColumnDefinitions.Add(new ColumnDefinition());
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        Button txt = new Button();
                        txt.Content = Numb.ToString();
                        txt.Height = 30;
                        txt.Click += new RoutedEventHandler(Button_Room);
                        Numb++;
                        AddRoom.Children.Add(txt);
                        Grid.SetColumn(txt, i);
                    }
                    spRoom.Children.Add(AddRoom);
                }
                Grid LastAddRoom = new Grid();
                LastAddRoom.Margin = new Thickness(0, 5, 0, 0);
                for (int i = 0; i < 20; i++)
                {
                    LastAddRoom.ColumnDefinitions.Add(new ColumnDefinition());
                }
                for (int i = 0; i < amount % 20; i++)
                {
                    Button txt = new Button();
                    txt.Content = Numb.ToString();
                    txt.Height = 30;
                    txt.Click += new RoutedEventHandler(Button_Room);
                    Numb++;
                    LastAddRoom.Children.Add(txt);
                    Grid.SetColumn(txt, i);
                }
                spRoom.Children.Add(LastAddRoom);

            }
        }
        private void Button_Room(object sender, RoutedEventArgs e)
        {
            
            Apartament apartament = new Apartament();
            apartament.Numb = int.Parse((sender as Button).Content.ToString());
            GenerateRoom generateRoom = new GenerateRoom(ref apartament);
            generateRoom.ShowDialog();

            (sender as Button).Tag = apartament;

            using (Service1Client client = new Service1Client())
            {
                client.AddRoom(tbHotelName.Text, apartament);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                Address addr = new Address();
                addr.City = cbCity.Text;
                addr.Street = cbStreet.Text;
                addr.Country = new Country() { Name = cbContr.Text };
                if (!client.HotelIsReal(new Hotel() { Name = tbHotelName.Text }))
                {
                    client.AddHotel(new Hotel() {
                        Name = tbHotelName.Text,
                        Address=addr
                    });
                }
            }
              //  tbHotelName
        }

        
    }
}

