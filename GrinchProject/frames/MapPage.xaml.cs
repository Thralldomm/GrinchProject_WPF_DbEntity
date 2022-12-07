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
    /// Логика взаимодействия для MapPage.xaml
    /// </summary>
    public partial class MapPage : Page
    {

        MainWindow mainWindow;
        public MapPage(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
           
        }


        //TODO: разобраться с координатами до конца
        private void Map_Image_MouseDown(object sender, MouseButtonEventArgs e)
        { 
            cursor_textblock.Text = Mouse.GetPosition(Application.Current.MainWindow).ToString();
            var str = Mouse.GetPosition(Application.Current.MainWindow).ToString();

            List<int> list = str.Split(';').Select(x => Convert.ToInt32(x)).ToList();


           
            if (list[0] > 244 && list[0]<293 && list[1]>155)
            { 
                if (MessageBox.Show("Mountain", "Area", MessageBoxButton.YesNo)==MessageBoxResult.Yes)
                {
                    //открываем страницу с фото, передаем mountain для контекста
               
                    mainWindow.MainFrame.Navigate(new HomeImage_Page(mainWindow, "mountain"));
                }
                
            }

            else if (list[0] > 607 && list[0] < 1025 && list[1] > 79 && list[1] < 435)
            { 
                if (MessageBox.Show("Town", "Area", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                { 
                    mainWindow.MainFrame.Navigate(new HomeImage_Page(mainWindow, "town"));
                }

            }

            else if (list[0] > 130 && list[0] < 400 && list[1] > 43 && list[1] < 568)
            { 
                if (MessageBox.Show("Forest", "Area", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                { 
                    mainWindow.MainFrame.Navigate(new HomeImage_Page(mainWindow, "forest"));
                }
            }

           else 
            {
                MessageBox.Show("Sky"); 
            }
        }


      //TODO: При нажатии некбокс - меняется режим на ночной - и обратно
        private void Mode_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Map_Image.Source = new BitmapImage(new Uri(@"\map_images\map_night_with_goat.jpg", UriKind.Relative));
        }

        private void Mode_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        { 
        }
    }
}
