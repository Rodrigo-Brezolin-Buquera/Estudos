namespace PTI_algoritmos2;

class Program
{
    static List<Book> stock = new List<Book>();
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao nosso sistema de estoque, escolha uma das opções abaixo");

        int option = showMenu();
        switch (option)
        {
            case 1:
                addProduct();
                break;
            case 2:
                showProducts();
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 0:
                Console.WriteLine("Obrigado por utilizar nossos serviços. Até uma próxima vez");
                break;
            default:
                Console.WriteLine("Obrigado por utilizar nossos serviços. Até uma próxima vez");
                break;
        }

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

    static void addProduct()
    {
        Console.WriteLine("Informe o nome do livro");
        string name = Console.ReadLine();

        Console.WriteLine("Informe o nome o preço ");
        string price = "R$ " + Console.ReadLine();

        Console.WriteLine("Informe o autor(a)");
        string author = Console.ReadLine();

        Console.WriteLine("Informe o gênero");
        string genre = Console.ReadLine();

        Book newBook = new Book(name, author, price, genre);
        stock.Add(newBook);
        
    }

    static void showProducts() 
    { 
      
       for (int i = 0; i < stock.Count; i++)
        {
                Book book = stock[i];
                Console.WriteLine($"{i+1}. {book}");
        }

    }

    static void removeProduct() { }

    static void changeQuantity() { }

    public class Book
    {
        string name;
        string author;
        string price;
        string genre;
        int quantity;

        public Book(string n, string a, string p, string g)
        {
            name = n;
            author = a;
            price = p;
            genre = g;
            quantity = 0;
        }

        public void addQuantity(int value)
        {
            // quantity = quantity + value;
        }

        public void removeQuantity(int value)
        {
        //    quantity = quantity - value;
        }

        public override string ToString()
        {
            return $"Nome: {name}, Autor: {author}, Preço: {price}, Gênero: {genre}, Quantidade: {quantity}" ; 
        }

    }
}
