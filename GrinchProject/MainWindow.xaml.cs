using GrinchProject.frames;
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

namespace GrinchProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            using (GrinchContext db = new GrinchContext())
            {
                //MyComboBox.ItemsSource = db.Places.Select(b => b.Area).Distinct().ToList();
                 
            }
        }
         

        private void Map_Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MapPage(this));
        }

        //TODO: При нажатии на кнопку выводится карта местности. Нажав мышью в определенное место, можно выбрать какой то район.
        //для этого надо проверить координаты мыши и отследить клик

        //Mouse.GetPosition(Application.Current.MainWindow);

        //нажимаем на место на карте - выходит сообщение с названием тыкнутого места (йес  ноу, йес - идем в это место.  ноу - просто закрвыаем месседж бокс)


        //заменить clif -> mountain

        //TODO: Добавить поле Фото в табличку Друзья для каждой комбинации
        //отображать фотот друзей при выборе (придумать как выбирать)

        //TODO: Добавить оленя Фреда в табличку

        //TODO: Добавить поля фото_день и фото_ночь в таблицу Место и отображать при выборе на карте.
        //Также сделать переключатель (радио баттон) для дневного и ночного режимов


        //TODO: Создать таблицу Дом с внешним ключом Место_Айди с полями название комнаты и фото комнаты

        //TODO: + фича - нажимаем на небо - попадаем на небеса (типо смешно йоу)



    }
}
