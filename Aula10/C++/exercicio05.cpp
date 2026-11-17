/* 
Exercício 05:
    Um sistema de vendas precisa representar produtos e pedidos. Cada pedido está associado a um produto.
      - Crie a classe Produto, com os atributos nome e preco;
      - Crie a classe Pedido, com um atributo que armazene um objeto da classe Produto e outro atributo 
        chamado quantidade;
      - No método Main, crie um produto, associe-o a um pedido e exiba o nome do produto, a quantidade e o 
        preço total da compra.
    
    EXEMPLO:
        Saída:      Produto = Xícara de Café                                                                                         
                    Quantidade = 3                                                                                                   
                    Preço total = R$ 31.50 
*/

#include <iostream>
#include <iomanip>
#include <locale>
#include <cstdlib>

using namespace std;

class Produto {
    public:
    string nome;
    double preco;

    // Inicializa o produto com nome e preço unitário
    Produto(string nome, double preco) {
        this->nome = nome;
        this->preco = preco;
    }
};

class Pedido {
    public:
    Produto produtoComprado;
    int quantidade;

    // Associa o produto ao pedido e define a quantidade comprada
    // produtoComprado(produto) inicializa o objeto Produto armazenado no pedido
    Pedido(Produto produto, int quantidade) : produtoComprado(produto) {
        this->quantidade = quantidade;
    }

    // Calcula o total da compra multiplicando o preço unitário pela quantidade
    double preco() {
        return produtoComprado.preco * quantidade;
    }
};

int main()
{
    setlocale(LC_ALL, "pt_BR.UTF-8");

    system("cls");
    cout << "=======================" << endl;
    cout << "   PREÇO DE PRODUTOS   " << endl;
    cout << "=======================\n" << endl;

    Produto produto("Xícara de Café", 10.50);
    Pedido pedido(produto, 3);

    cout << fixed << setprecision(2);
    cout << "Produto = " << pedido.produtoComprado.nome << endl;
    cout << "Quantidade = " << pedido.quantidade << endl;
    cout << "Preço total = R$ " << pedido.preco() << endl;
}