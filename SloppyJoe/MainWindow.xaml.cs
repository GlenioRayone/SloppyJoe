using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SloppyJoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }
        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;
            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i > 3)
                {
                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };
                }
                menuItems[i].Generate();
            }
            item1.Text = menuItems[0].Descrition;
            price1.Text = menuItems[0].Price;
            item2.Text = menuItems[1].Descrition;
            price2.Text = menuItems[1].Price;
            item3.Text = menuItems[2].Descrition;
            price3.Text = menuItems[2].Price;
            item4.Text = menuItems[3].Descrition;
            price4.Text = menuItems[3].Price;
            item5.Text = menuItems[4].Descrition;
            price5.Text = menuItems[4].Price;

            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic Ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dresseing", "aujus" }
            };
            specialMenuItem.Generate();

            item6.Text = specialMenuItem.Descrition;
            price6.Text = specialMenuItem.Price;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;
            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Price;
         
        }


    }
}