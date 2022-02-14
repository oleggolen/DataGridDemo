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

namespace DataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<House> Houses { get; set; }
        public House? SelectedHouse { get; set; }
        public MainWindow()
        {
            Houses = new List<House>()
            {
                new()
                {
                    Address = "Obskaya 50",
                    Entrances = 3,
                    Floors = 16,
                    HasLift = true,
                    Id = 1
                },
                new ()
                {
                    Address = "Red Square 1",
                    Entrances = 8,
                    Floors = 6,
                    HasLift = false,
                    Id = 2

                },
                new ()
                {
                    Address = "Lenin Square, 1 ",
                    Entrances = 4,
                    Floors = 3,
                    HasLift = false,
                    Id = 3
                }
            };
            InitializeComponent();
        }

        private void Update_OnClick(object sender, RoutedEventArgs e)
        {
            if (SelectedHouse == null)
                return;
            var editHouse = new EditHouse() {House = SelectedHouse};
            editHouse.ShowDialog();
        }
    }
}