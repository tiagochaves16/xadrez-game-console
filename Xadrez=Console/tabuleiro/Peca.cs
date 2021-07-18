

namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            Cor = cor;
            this.tab = tab;
            this.qtdMovimentos = 0;
        }

        public void incrementarQtdMovimento()
        {
            qtdMovimentos++;
        }

        public void decrementarQtdMovimento()
        {
            qtdMovimentos--;
        }

        //Verifica se existe movimentos possíveis nas pecas
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentoPossiveis();
            for (int i = 0; i < tab.linha; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j]) return true;
                }
            }

            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentoPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentoPossiveis();
       
    }
}
