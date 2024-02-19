namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position starOffSet { get; }
        public abstract int id {  get; }
        private int rotationState;
        private Position offset;
        public Block()
        {
            offset=new Position(starOffSet.Row, starOffSet.Column);
        }
        public IEnumerable<Position> tilePosition()
        {
            foreach(Position p in Tiles[rotationState]) 
            {
                yield return new Position (p.Row+offset.Row,p.Column+offset.Column);
            }
        }
        public void rotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;

        }
        public void rotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void move(int rows, int columns)
        {
            offset.Row = rows;
            offset.Column = columns;
        }
        public void reset()
        {
            rotationState = 0;
            offset.Row=starOffSet.Row;
            offset.Column=starOffSet.Column;
        }
    }
    
}
