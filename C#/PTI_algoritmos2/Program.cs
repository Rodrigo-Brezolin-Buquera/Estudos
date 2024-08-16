namespace PTI_algoritmos2;

class Program
{
    static List<Book> stock = new List<Book>();

    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao nosso sistema de estoque, escolha uma das opções abaixo");

        bool showingMenu = true;
        Actions act = new Actions();

        while (showingMenu)
        {
            int option = act.ShowMenu();
            switch (option)
            {
                case 1:
                    act.AddProduct(stock);
                    break;
                case 2:
                    act.ShowProducts(stock);
                    break;
                case 3:
                    act.RemoveProduct(stock);
                    break;
                case 4:
                    act.AddQuantity(stock);
                    break;
                case 5:
                    act.RemoveQuantity(stock);
                    break;
                case 0:
                    Console.WriteLine("Obrigado por utilizar nossos serviços. Até uma próxima vez!");
                    showingMenu = false;
                    break;
                default:
                    Console.WriteLine("Obrigado por utilizar nossos serviços. Até uma próxima vez!");
                    showingMenu = false;
                    break;
            }
        }
    }
}
