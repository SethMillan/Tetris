namespace Tetris
{
    public class GameGrid
    {
        //Se crea un objeto grid que es nuestra cuadricula
        private readonly int[,] grid;
        //Manipulacion de filas
        public int Rows { get; }
        //Manipulacion de columnas
        public int Columns { get; }
        //indexamos la clase para manejar nuestra matriz bidimensional como un arreglo con los corchetes
        public int this[int x, int y] { 
            get {  return grid[x, y]; } 
            set { grid[x, y] = value;}
        }
        //Constructor
        public GameGrid(int rows, int columns)
        {
            Rows=rows; Columns=columns;
            grid=new int[Rows, Columns];
        }
        //Para verificar que los valores estan dentro de la cuadricula
        public bool isInside(int x, int y)
        {
            return x>=0&&x<Rows&&y>=0&&y<Columns;
        }
        //para verificar si la casilla esta vacia
        public bool isEmpty(int x, int y)
        {
            return isInside(x, y) && grid[x, y] == 0;
        }
        //verifica si una fila esta llena
        public bool isRowFull(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //lo mismo de arriba ahora lo contrario jaja
        public bool isRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r, c] != 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
