namespace Tetris
{
    public class GameState
    {
        private Block currentBlock;
        public Block CurrentBlock 
        {
            get => currentBlock;
            private set
            {
                currentBlock = value;
                currentBlock.reset();
                for (int i = 0; i < 2; i++)
                {
                    currentBlock.move(1, 0);
                    if(!BlockFirst()) 
                    {
                        currentBlock.move(-1, 0);
                    }
                }
            }
        }

        public GameGrid GameGrid { get;}
        public BlockQueue BlockQueue { get;}
        public int Score { get; private set; }
        public bool GameOver { get; private set; }
        public GameState()
        {
            GameGrid=new GameGrid(22,10);
            BlockQueue=new BlockQueue();
            CurrentBlock = BlockQueue.GetAndUpdate();        
        }
        private bool BlockFirst()
        {
            foreach(Position p in CurrentBlock.tilePosition())
            {
                if (!GameGrid.isEmpty(p.Row, p.Column))
                {
                    return false;
                }
            }
            return true;
        }


        public void RotateBlockCW()
        {
            CurrentBlock.rotateCW();
            if(!BlockFirst())
            {
                CurrentBlock.rotateCCW();
            }
        }


        public void RotateBlockCCW()
        {
            CurrentBlock.rotateCCW();
            if(!BlockFirst())
            {
                CurrentBlock.rotateCW();
            }
        }

        public void MoveBlockLeft()
        {
            CurrentBlock.move(0, -1);
            if(!BlockFirst())
            {
                CurrentBlock.move(0, 1);
            }
        }

        public void MoveBlockRight()
        {
            CurrentBlock.move(0, 1);
            if(!BlockFirst())
            {
                CurrentBlock.move(0, -1);
            }
        }

        private bool IsGameOver()
        {
            return !(GameGrid.isRowEmpty(0) && GameGrid.isRowEmpty(1));
        }

        private void PlaceBlock()
        {
            foreach(Position p in CurrentBlock.tilePosition())
            {
                GameGrid[p.Row, p.Column] = CurrentBlock.id;
            }
            Score+=GameGrid.clearFullRows();
            if (IsGameOver())
            {
                GameOver = true;
            }
            else
            {
                CurrentBlock = BlockQueue.GetAndUpdate();
            }
        }

        public void moveDownBlock()
        {
            currentBlock.move(1, 0);
            if(!BlockFirst())
            {
                CurrentBlock.move(-1, 0);
                PlaceBlock();
            }
        }



    }
}
