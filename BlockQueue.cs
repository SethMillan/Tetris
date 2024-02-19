using System;
namespace Tetris
{
    //Esta clase va a ser la "bolsa" random de la que sacamos nuestros bloques
    //aunque tecnicamente no es tan random
    //Como tal no es una bolsa pero si evita repeticiones
    public class BlockQueue
    {
        //Esta es la bolsa que tiene todos los bloques
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };
        private readonly Random random= new Random();
        //Hacemos uso de Random importandola del sistema con el using system que esta al inicio

        public BlockQueue() 
        {
            NextBlock = RandomBlock();
            //Aqui solamente mandamos llamar a la funcion de RandomBlock para que se llame el BlockQueue
        }


        public Block NextBlock { get; private set; }
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
            //Aqui dice que se returna un bloque random de entre los que se tiene en la lista
        }

        //Este metodo hara que no salgan bloques repetidos
        //No es una bolsa pero al menos no se repiten 
        public Block GetAndUpdate()
        {
            Block block = NextBlock;
            do
            {
                NextBlock = RandomBlock();

            } while (block.id == NextBlock.id);
            return block;
        }


    }
}
