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

        public void AddQuantity(int value)
        {
            quantity = quantity + value;
        }

        public void RemoveQuantity(int value)
        {
            quantity = quantity - value;
        }

        public override string ToString()
        {
            return $"{name} ({price}) - {quantity} no estoque";
        }

    }