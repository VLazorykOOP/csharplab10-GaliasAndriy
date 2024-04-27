
namespace Lab9_10CharpT
{
    public class TasksUsage
    {
        public static void Program1()
        {
           try
            {
                IProduct[] inventory = new IProduct[]
                {
                    new Toy("Lego", 100, "LEGO Group", "plastic", 2, "kids"),
                    new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 200, "Bloomsbury", 10, "kids"),
                    new SportsEquipment("Football", 79, "Nike", 12),
                    new Toy("Car: Ford Mustang 1967", 10, "Hot Wheels", "metal", 3, "boys")
                };

                Console.WriteLine("Full information from the inventory:");
                foreach (var product in inventory)
                {
                    product.DisplayInfo();
                    Console.WriteLine();
                }
            }
            catch (InvalidProductException ex)
            {
                Console.WriteLine($"Invalid product: {ex.Message}");
            }
            catch (InvalidProductTypeException ex)
            {
                Console.WriteLine($"Invalid product type: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

        }

        public static void Program2()
        {
            //
        }
    }
}
