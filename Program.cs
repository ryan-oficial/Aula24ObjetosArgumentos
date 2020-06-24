using System;

namespace Aula24Objetos_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            
            Produto p1 = new Produto(1, "Red Dead Redemption II", 299.99f);
            Produto p2 = new Produto(2, "Hollow knight", 30f);
            Produto p3 = new Produto(3, "Dead Cells", 27.87f);
            Produto p4 = new Produto(4, "Detroid Become Human", 99.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p3);

            Produto p5 = new Produto(1, "Celeste", 29.89f);
            cart.Alterar(1, p5);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
