public class Book
{
    string Name;
    string Author;
    string Price;
    string Genre;
    int Quantity;

    public Book(string n, string a, string p, string g)
    {
        Name = n;
        Author = a;
        Price = p;
        Genre = g;
        Quantity = 0;
    }

    public void AddQuantity(int value)
    {
        Quantity = Quantity + value;
    }

    public void RemoveQuantity(int value)
    {
        Quantity = Quantity - value;
    }

    public override string ToString()
    {
        return $"{Name} ({Price}) - {Quantity} no estoque";
    }

}