namespace Mercado{
    class Program{
        public static void Main(string [] args){
            Console.WriteLine("Teste");

            Carrinho c = new Carrinho();
            Produto p = new Produto("Holybibble");

            c.adicionarProduto(p);
            c.adicionarProduto(new Produto("Escova de dente"));
            c.adicionarProduto(new Produto("PS5"));
            c.adicionarProduto(new Produto("Rubber Duck"));

          //  c.adicionarProduto({new Produto("Rubber Duck")});

           // c.mostrarProdutos();

            List<Produto> pdts = c.getProdutos();

            foreach(Produto prod in pdts){
                Console.WriteLine(prod.getNome());
            }



            //List<int> numeros = new List<int>();
           // int[] numeros2  = new int[10];

        }
    }


    class Carrinho{
       // private Produto p;
        private List<Produto> produtos  = new List<Produto>();


        public void adicionarProduto(Produto p){
            this.produtos.Add(p);
        }

        public void mostrarProdutos(){

            for(int i =0; i < this.produtos.Count; i++){
                Console.WriteLine(produtos[i].getNome());
            }
            /*
            foreach(Produto p in this.produtos){
                Console.WriteLine(p.getNome());
            }
            */
        }

        public List<Produto> getProdutos(){
            return this.produtos;
        }

    }

    class Produto{
        private string nome;

        public Produto(string nome){
            this.nome = nome;
        }

        public string getNome(){
            return this.nome;
        }

    }
}
