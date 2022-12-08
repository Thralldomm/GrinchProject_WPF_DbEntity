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
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {

        MainWindow mainWindow;
        public CharacterPage(Character character, MainWindow mainWindow)  //character object
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            using(GrinchContext db = new GrinchContext())
            {
                Character_ListView.ItemsSource = db.Characters.ToList();

                Main_Character_Grid.DataContext = character;

                
            }

            //TODO: Поменять в xaml placeId на название места
        }

        private void Character_ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("new page with new context");

            
        }

        private void character_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MainFrame.Navigate(new CharacterPage((sender as Button).DataContext as Character, mainWindow));
        }
    }
}
