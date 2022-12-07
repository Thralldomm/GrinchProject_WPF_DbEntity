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
        public HomeImage_Page(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            using(GrinchContext db = new GrinchContext())
            {
                MyDocky.DataContext = db.Places.Where(b => b.Id == 1).ToList();
            }
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
