namespace ProjetoPilha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TADPilha pilha = new TADPilha(20, "pilha",30);
            pilha.empilhar(5);
            pilha.empilhar(4);
            pilha.empilhar(8);
            pilha.empilhar(1);
            pilha.desempilhar();
            pilha.empilhar(3);
            pilha.listar();
            pilha.empilhar(20);
            pilha.empilhar(5);
            pilha.listar();

        }
    }
}
