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
            new BitmapImage(new Uri("Assets/TileRed.png",UriKind.Relative))
        };
        private readonly ImageSource[] blocksImages = new ImageSource[]
        {
            new BitmapImage(new Uri("Assets/Block-Empty.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-I.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-J.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-L.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-O.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-S.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-T.png",UriKind.Relative)),
            new BitmapImage(new Uri("Assets/Block-Z.png",UriKind.Relative))
        };
        private readonly Image[,] imageControls;
        private GameState gameState=new GameState();

        public MainWindow()
        {
            InitializeComponent();
            imageControls = SetupGameCanvas(gameState.GameGrid);
        }

        private Image[,] SetupGameCanvas(GameGrid grid)
        {
            Image[,] imageControls = new Image[grid.Rows, grid.Columns];
            int cellSize = 25;
            for (int r = 0; r < grid.Rows; r++)
            {

                for (int c = 0; c < grid.Columns; c++)
                {
                    Image ImageControl = new Image
                    {
                        Width = cellSize,
                        Height = cellSize
                    };
                    Canvas.SetTop(ImageControl, (r - 2) * cellSize);
                    Canvas.SetLeft(ImageControl, c * cellSize);
                    GameCanvas.Children.Add(ImageControl);
                    imageControls[r, c] = ImageControl;

                }

            }
            return imageControls;

        }
        private void DrawGrid(GameGrid grid)
        {
            for (int r = 0; r < grid.Rows; r++)
            {
                for(int c=0; c<grid.Columns; c++)
                {
                    int id = grid[r, c];
                    imageControls[r, c].Source = tileImages[id];
                }
            }

        }
        private void DrawBlock(Block block)
        {
            foreach(Position p in block.tilePosition())
            {
                imageControls[p.Row,p.Column].Source=tileImages[block.id];
            }
        }
        private void Draw(GameState gameState)
        {
            DrawGrid(gameState.GameGrid);
            DrawBlock(gameState.CurrentBlock);
        }



        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // Aquí puedes manejar el evento KeyDown
            if (gameState.GameOver)
            {
                return;
            }
            switch(e.Key)
            {
                case Key.Left:
                    gameState.MoveBlockLeft();
                    break;
                case Key.Right: 
                    gameState.MoveBlockRight();
                    break;
                case Key.Down:
                    gameState.moveDownBlock();
                    break;
                case Key.Up:
                    gameState.RotateBlockCW();
                    break;
                case Key.Z:
                    gameState.RotateBlockCCW();
                    break;
                    default: return;
            }
            Draw(gameState);
        }
        private void GameCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando el Canvas se carga
            Draw(gameState);
        }
        private void PlayAgain_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica que deseas ejecutar cuando se hace clic en el botón "Play Again"
            // Por ejemplo, puedes reiniciar el juego o realizar cualquier otra acción necesaria.
        }
    }
}