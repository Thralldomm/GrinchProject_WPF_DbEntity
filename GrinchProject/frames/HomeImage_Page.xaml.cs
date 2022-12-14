using GrinchProject.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GrinchProject.frames
{
    /// <summary>
    /// Логика взаимодействия для HomeImage_Page.xaml
    /// </summary>
    public partial class HomeImage_Page : Page
    {
        MainWindow mainWindow;

        List<Character>? b;


        public HomeImage_Page(MainWindow mainWindow,
                                string AreaName)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            //statusUser.Text = user.RoleNavigation.Name;

            using(GrinchContext db = new GrinchContext())
            {
                if(AreaName == "town")
                {
                    mainGrid.DataContext = db.Places.Where(d => d.Area == "town").ToList();

                    var a = db.Characters.Where(r => r.PlaceId == 1).ToList();
                    first_Character_Image.DataContext = a[0];
                    second_Character_Image.DataContext = a[1];

                    b = a;
                }
            }
           
        }

        
        private void ModeToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void first_Character_Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
             
               mainWindow.MainFrame.Navigate(new CharacterPage(b[0], mainWindow));
             
        }
    }
}
