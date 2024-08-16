public class Actions
{
    public int ShowMenu()
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

    public void AddProduct(List<Book> stock)
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

        Console.WriteLine("Livro Adicionado!");

    }

    public void ShowProducts(List<Book> stock)
    {
        if (stock.Count == 0)
        {
            Console.WriteLine("Nenhum livro no estoque");
        }
        else
        {

            for (int i = 0; i < stock.Count; i++)
            {
                Book book = stock[i];
                Console.WriteLine($"{i + 1}. {book}");
            }
        }

    }

    public void RemoveProduct(List<Book> stock)
    {
        int index = this.FindBook(stock);

        if (index != -1)
        {
            stock.RemoveAt(index);
            Console.WriteLine("Livro removido com sucesso.");
        }
    }

    public void AddQuantity(List<Book> stock)
    {
        int index = this.FindBook(stock);
        if (index != -1)
        {
            Console.WriteLine("Informe a quantidade de entrada");
            int quantity = int.Parse(Console.ReadLine());
            stock[index].AddQuantity(quantity);
        }

    }

    public void RemoveQuantity(List<Book> stock)
    {
        int index = this.FindBook(stock);
        if (index != -1)
        {
            Console.WriteLine("Informe a quantidade de saída");
            int quantity = int.Parse(Console.ReadLine());
            stock[index].RemoveQuantity(quantity);
        }
    }

    private int FindBook(List<Book> stock)
    {
        Console.WriteLine("Informe a posição do livro a ser removido");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < stock.Count)
        {
            return index;
        }
        else
        {
            Console.WriteLine("Livro não encontrado");
            return -1;
        }
    }

}