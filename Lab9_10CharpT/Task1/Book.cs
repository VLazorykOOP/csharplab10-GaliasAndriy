namespace Lab9_10CharpT {
    using System;

    class Book : IProduct
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int Age { get; set; }

        public Book(string name, string author, double price, string publisher, int age)
        {
            Name = name;
            Author = author;
            Price = price;
            Publisher = publisher;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Book: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
        }

        public bool IsType(string type)
        {
            return type == "Book";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            IProduct otherProduct = obj as IProduct;
            if (otherProduct != null)
                return this.Name.CompareTo(otherProduct.Name);
            else
                throw new ArgumentException("Object is not an IProduct");
        }
    }
}