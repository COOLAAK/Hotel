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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            using (Service1Client client = new Service1Client())
            {
                List<Country> country= client.GetCountries().ToList();
                foreach (var item in country)
                {
                    cbContr.Items.Add(item.Name);
                }
            }
                cbContr.SelectedIndex = 0;
            
        }
    }
}
