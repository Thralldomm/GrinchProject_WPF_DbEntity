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


                ////////////////////////
                List<string> l = new List<string>();

                l.Add("Default");
                l.Add("Ascending");
                l.Add("Descending");

                Sort_ComboBox.ItemsSource = l;

                Sort_ComboBox.SelectedIndex = 0;
                ////////////////////////

                var s = db.Places.Select(b => b.Area).Distinct().ToList();
                s.Insert(0, "None");
                Filter_ComboBox.ItemsSource = s;

            }

            //TODO: Поменять в xaml placeId на название места

            //TODO: Добавить страницу для добавления и редактирования объектов

            //TODO: Добавить окно авторизации: если вы есть в системе, можно редактировать, если нет - зайти гостем и спрятать кнопки
        }



        private void Character_ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("new page with new context");

            
        }


        /// <summary>
        /// Передать контекстом объект ListView кнопку которого нажали и открыть страницу CharacterPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void character_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MainFrame.Navigate(new CharacterPage((sender as Button).DataContext as Character, mainWindow));
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MainFrame.Navigate(new Add_Page(null, mainWindow));
        }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = Character_ListView.SelectedItems.Cast<Character>().ToList();

            using(GrinchContext db = new GrinchContext())
            {
                foreach (var a in selected)
                {
                    db.Characters.Attach(a);
                }

                db.RemoveRange(selected);
                db.SaveChanges();


                Character_ListView.ItemsSource = db.Characters.ToList();

                
            }
            
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MainFrame.Navigate(new Add_Page((sender as Button).DataContext as Character, mainWindow));
        }

        private void Search_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using(GrinchContext db = new GrinchContext())
            {
                var found = db.Characters.Where(u => u.Name.Contains(Search_TextBox.Text) || u.Description.Contains(Search_TextBox.Text)).ToList();
                 
                Character_ListView.ItemsSource = found;
            }
        }

        private void Sort_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // switch ... case

            using(GrinchContext db = new GrinchContext())
            {
                if(Sort_ComboBox.SelectedIndex == 0)
                {
                    Character_ListView.ItemsSource = db.Characters.ToList();
                }
                if(Sort_ComboBox.SelectedIndex == 1)
                {
                    Character_ListView.ItemsSource = db.Characters.ToList().OrderBy(b => b.Name);
                }
                if (Sort_ComboBox.SelectedIndex == 2)
                {
                    Character_ListView.ItemsSource = db.Characters.ToList().OrderByDescending(b => b.Name);
                }
            }
            
        }

         
        private void Filter_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

              MessageBox.Show(Filter_ComboBox.SelectedValue.ToString());

            using(GrinchContext db = new GrinchContext())
            {
                Place p = db.Places.Where(b => b.Area == Filter_ComboBox.SelectedValue.ToString()).FirstOrDefault();

                var characters = db.Characters.Where(b => b.PlaceId == p.Id).ToList();

                Character_ListView.ItemsSource = characters;
                

            }

        }
    }
}
