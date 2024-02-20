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

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ImageSource[] tileImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/TileEmpty.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileCyan.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileBlue.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileOrange.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileYellow.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileGreen.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TilePurple.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/TileRead.png",UriKind.Relative))
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Aquí puedes manejar el evento KeyDown
        }
        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el Canvas se carga
        }
        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando se hace clic en el botón "Play Again"
            // Por ejemplo, puedes reiniciar el juego o realizar cualquier otra acción necesaria.
        }
    }
}