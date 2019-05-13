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

namespace HotelWpf
{
    /// <summary>
    /// Interaction logic for GenerateRoom.xaml
    /// </summary>
    public partial class GenerateRoom : Window
    {
         List<int>room;
        public GenerateRoom( ref List<int> room)
        {
            InitializeComponent();
            this.room = room;
            for (int i = 0; i < room.Count; i++)
            {
                StackPanel stack = new StackPanel();
                stack.Orientation = Orientation.Horizontal;
                
                TextBlock tbx = new TextBlock() { Text = $"Поверх  {i+1} :" };
                TextBox cb = new TextBox();
                cb.Width = 100;
                cb.Text = $"{i + 1}Працює";
                stack.Children.Add(tbx);
                stack.Children.Add(cb);


                stack.Margin = new Thickness(10, 10, 0, 0);
                DockPanel.SetDock(stack, Dock.Top);
                dpAdd.Children.Add(stack);
            }
            
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int countRoom=  dpAdd.Children.Count;
            for (int i = 0; i < countRoom; i++)
            {
                if (dpAdd.Children[i] is StackPanel)
                {
                    StackPanel good = dpAdd.Children[i] as StackPanel;
                    if (good.Children[1] is TextBox)
                    {
                        room[i] = int.Parse((good.Children[1] as TextBox).Text);
                    }
                }
            }
            this.Close();
        }
    }
}
