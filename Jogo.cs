namespace Aula16Construtor
{
    public class Jogo
    {
        public int preco {get; set;}
        public string nome {get; set;}
        public string descricao {get; set;}
        public string estoque {get; set;}

        public Jogo(){

        }
        public Jogo(string _nome){
            this.nome = _nome;;
        }
        public Jogo(string _nome, int _preco, string _descricao, string _estoque){
            this.nome = _nome;
            this.preco = _preco;
            this.descricao = _descricao;
            this.estoque = _estoque;
        }
    }
}