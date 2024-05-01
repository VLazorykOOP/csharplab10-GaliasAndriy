namespace Lab9_10CharpT {

    public class Toy : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public int Age { get; set; }
        public string ToyColor { get; set; }

        public Toy(string name, double price, string manufacturer, string material, int age)
        {
            try {
                if (name == null || manufacturer == null) 
                {
                    throw new ArgumentNullException("ArgumentNullException. Title of toy or price or manufacturer can't be null.");
                }
                Name = name;
                Price = price;
                Manufacturer = manufacturer;
                Material = material;

                if (Name.ToLower() == "lego" && (age < 3 || age > 99))
                    throw new IndexOutOfRangeException("Age should be between 3 and 99 for Lego toys.");
                
                if (age < 3)
                    throw new IndexOutOfRangeException("Age should be more than 3+.");

                if (price <= 0)
                    throw new DivideByZeroException("Divid By Zero Exception. Price can't be ZERO value");

                Age = age;
            }
            catch (ArgumentException ex) {
                Console.WriteLine($"Error while creating new Toy: {ex.Message}");
            }
        }
        public Toy(string name, double price, string manufacturer, string material, string toyColor, int age)
        {
            try {
                if (name == null || manufacturer == null) 
                {
                    throw new ArgumentNullException("ArgumentNullException. Title of toy or price or manufacturer can't be null.");
                }
                Name = name;
                Price = price;
                Manufacturer = manufacturer;
                Material = material;
                ToyColor = toyColor;

                if (Name.ToLower() == "lego" && (age < 3 || age > 99))
                    throw new IndexOutOfRangeException("Age should be between 3 and 99 for Lego toys.");
                
                if (age < 3)
                    throw new IndexOutOfRangeException("Age should be more than 3+.");

                if (price <= 0)
                    throw new DivideByZeroException("Divid By Zero Exception. Price can't be ZERO value");

                Age = age;
            }
            catch (ArgumentException ex) {
                Console.WriteLine($"Error while creating new Toy: {ex.Message}");
            }
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Toy: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Age range: {Age}+");
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