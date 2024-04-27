using System;

namespace Lab9_10CharpT {
    class SportsEquipment : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public int Age { get; set; }

        public SportsEquipment(string name, decimal price, string manufacturer, int age)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Sports Equipment: {Name}");
            Console.ResetColor();
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Age Range: {Age}");
        }

        public bool IsType(string type)
        {
            return type == "Sports Equipment";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            IProduct otherProduct = obj as IProduct;
            if (otherProduct != null)
                return this.Name.CompareTo(otherProduct.Name);
            else
                throw new ArgumentException("Object is not a SportsEquipment");
        }
    }
}
