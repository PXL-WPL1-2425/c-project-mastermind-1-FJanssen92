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

namespace MastermindCSProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "Mastermind " + "(" + RandomColors() + ")";



        }

        public string RandomColors()
        {
            Random newColor = new Random();
            string randomColor;
            StringBuilder colorCode = new StringBuilder();



            for (int i = 1; i <= 4; i++)
            {
                randomColor = (newColor.Next(1, 7)).ToString();
                switch (randomColor)
                {
                    case "1":
                        randomColor = "White";
                        break;
                    case "2":
                        randomColor = "Red";
                        break;
                    case "3":
                        randomColor = "Blue";
                        break;
                    case "4":
                        randomColor = "Green";
                        break;
                    case "5":
                        randomColor = "Yellow";
                        break;
                    case "6":
                        randomColor = "Orange";
                        break;
                }

                colorCode.Append($"{randomColor}, ");

            }

            string colors = colorCode.ToString();
            return colors;

        }

        private void color1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (color1ComboBox.SelectedIndex)
            {
                case 0:
                    color1Label.Background = Brushes.White;
                    break;
                case 1:
                    color1Label.Background = Brushes.Red;
                    break;
                case 2:
                    color1Label.Background = Brushes.Blue;
                    break;
                case 3:
                    color1Label.Background = Brushes.Green;
                    break;
                case 4:
                    color1Label.Background = Brushes.Orange;
                    break;
                case 5:
                    color1Label.Background = Brushes.Yellow;
                    break;
            }
        }

        private void color2ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (color2ComboBox.SelectedIndex)
            {
                case 0:
                    color2Label.Background = Brushes.White;
                    break;
                case 1:
                    color2Label.Background = Brushes.Red;
                    break;
                case 2:
                    color2Label.Background = Brushes.Blue;
                    break;
                case 3:
                    color2Label.Background = Brushes.Green;
                    break;
                case 4:
                    color2Label.Background = Brushes.Orange;
                    break;
                case 5:
                    color2Label.Background = Brushes.Yellow;
                    break;
            }
        }

        private void color3ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (color3ComboBox.SelectedIndex)
            {
                case 0:
                    color3Label.Background = Brushes.White;
                    break;
                case 1:
                    color3Label.Background = Brushes.Red;
                    break;
                case 2:
                    color3Label.Background = Brushes.Blue;
                    break;
                case 3:
                    color3Label.Background = Brushes.Green;
                    break;
                case 4:
                    color3Label.Background = Brushes.Orange;
                    break;
                case 5:
                    color3Label.Background = Brushes.Yellow;
                    break;
            }
        }

        private void color4ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (color4ComboBox.SelectedIndex)
            {
                case 0:
                    color4Label.Background = Brushes.White;
                    break;
                case 1:
                    color4Label.Background = Brushes.Red;
                    break;
                case 2:
                    color4Label.Background = Brushes.Blue;
                    break;
                case 3:
                    color4Label.Background = Brushes.Green;
                    break;
                case 4:
                    color4Label.Background = Brushes.Orange;
                    break;
                case 5:
                    color4Label.Background = Brushes.Yellow;
                    break;
            }
        }
    }
}