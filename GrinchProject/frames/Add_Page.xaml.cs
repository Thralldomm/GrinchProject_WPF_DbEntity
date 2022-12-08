using GrinchProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
    //TODO: Порабоать со стилями в app.xaml
    public partial class Add_Page : Page
    {
        MainWindow mainWindow;

        Character character = new Character();


        public Add_Page(Character character, MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            GrinchContext db = new GrinchContext();
            Place_ComboBox.ItemsSource = db.Characters.Select(b => b.PlaceId).Distinct().ToList();

            if (character != null)
            {
                this.character = character;
            }

            Character_Grid.DataContext = this.character;
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
           
            character.Name = Name_TextBox.Text;
            character.Description = Description_TextBox.Text;
            character.ImagePath = Day_Image.Source.ToString();

            character.PlaceId = Int32.Parse(Place_ComboBox.Text);


            try
            {
                using(GrinchContext db = new GrinchContext())
                {
                    db.Characters.Add(character);
                    db.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            mainWindow.MainFrame.Navigate(new CharacterPage(null, mainWindow));
        }
 

        private void Add_Image_Button_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream;
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                if ((myStream = dialog.OpenFile()) != null)
                {
                    string filename = dialog.FileName;

                    dialog.DefaultExt = ".png";
                    dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                    dialog.Title = "Open Image";
                    dialog.InitialDirectory = @"C:\Users\123\";


                    BitmapImage image = new BitmapImage(new Uri(filename));
                    Day_Image.Source = image;
                }

                myStream.Dispose();
            }
        }
    }
}
