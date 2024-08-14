namespace PTI_algoritmos2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao nosso sistema de estoque, escolha uma das opções abaixo");
        int option = showMenu();
    }

    static int showMenu()
    {
        bool validOption = false;
        int option = -1;

        while (validOption == false)
        {
            Console.WriteLine(" [1] Novo \n [2] Listar Produtos\n [3] Remover Produtos \n [4] Entrada Estoque\n [5] Saída Estoque\n [0] Sair");
            option = int.Parse(Console.ReadLine());

            if (option >= 0 && option < 6)
            {
                validOption = true;
            }
            else
            {
                Console.WriteLine("Entre com um opção válida");
            }
        }

        return option;
    }

    static void addProduct() { }

    static void showProducts() { }

    static void removeProduct() { }

    static void changeQuantity() { }

    public class Book
    {
        string name;
        string author;
        double price;
        string genre;      
        int quantity;

        public Book(string n, string a, double p, string g)
        {
            name = n;
            author = a;
            price = p;
            genre = g;
            quantity = 0;
        }

        public void addQuantity(int value)
        {

        }

        public void removeQuantity(int value)
        {

        }

    }
}
