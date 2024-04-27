namespace Lab9_10CharpT {

    public class Toy : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public int Age { get; set; }

        public Toy(string name, decimal price, string manufacturer, string material, int age, string forAge)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Material = material;
            if (Name.ToLower() == "lego" && age < 3)
            {
                throw new InvalidProductException("Age should be 3 or more for Lego toys.");
            }
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Toy: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Age range: {Age}");
        }

        public bool IsType(string type)
        {
            return type == "Toy";
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            IProduct otherProduct = obj as IProduct;
            if (otherProduct != null)
                return Name.CompareTo(otherProduct.Name);
            else
                throw new ArgumentException("Object is not an IProduct");
        }
    }
}