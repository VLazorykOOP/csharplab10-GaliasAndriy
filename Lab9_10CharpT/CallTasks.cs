
namespace Lab9_10CharpT
{
    public class TasksUsage
    {
        public static void Program1()
        {
            try
            {
            // inventory can consists of 5 items. No more than 5
            IProduct[] inventory1 = new IProduct[]
            {
                new Toy("Lego", 100, "LEGO Group", "plastic", 3),
                new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 9.99, "Bloomsbury", 9),
                // only football and basketball available
                new SportsEquipment("Hockey", 79, "Nike", 12),
                new Toy("Car: Ford Mustang 1967", 10, "Hot Wheels", "metal", 3)
            };

            IProduct[] inventory6 = new IProduct[]
            {
                new Toy("Subaru Impreza WRC 2007", 6.39, "Kinsmart", "metal", "blue-dirt", 3),
                new Toy("Mitsubishi Lancer Evolution X 2008", 6.29, "Kinsmart", "metal", "blue", 3),
                new Toy("Bugatti Chiron Super Sport", 6.995, "Kinsmart", "black-red", 3),
                new Toy("Chevrolet Impala 1967", 6.45, "Kinsmart", "black", 3),
                new Toy("Audi R8 Coupe 2020", 6.10, "Kinsmart", "red", 3),
                //new Toy("Aston Martin DB5", 6.43, "Kinsmart", "grey", 3)
            };

            if (inventory1.Length > 5 || inventory6.Length > 5)
                throw new OverflowException("OverflowException. Maximum number of toys reached.");

            Console.WriteLine("Full information from the inventory1:");
            foreach (var product in inventory1)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Full information from the inventory6:");
            foreach (var product in inventory6)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("TEST ON SONGS:");
            MusicCatalog catalog = new();
            catalog.AddMusicCD("CD1", "Artist 1");
            catalog.AddMusicCD("CD2", "Artist 2");

            catalog.AddSong("CD1", "Song 1", "Artist 1", "Album 1", new Time(3, 25));
            catalog.AddSong("CD1", "Song 2", "Artist 1", "Album 1", new Time(3, 33));
            catalog.AddSong("CD2", "Song 3", "Artist 2", "Album 2", new Time(1, 32));
            catalog.AddSong("CD2", "Song 4", "Artist 3", "Album 3", new Time(3, 59));

            catalog.DisplayCatalog();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Show after changes");
            Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Not predicted exception: {ex.Message}");
            }
        }

        public static void Program2()
        {
            // Створюємо студента
            Student student = new Student("John", "Doe", 20);

            // Додаємо предмети
            Course mathCourse = new Course("Mathematics", "Prof. Smith", DayOfWeek.Monday, new TimeSpan(9, 0, 0));
            Course physicsCourse = new Course("Physics", "Prof. Johnson", DayOfWeek.Wednesday, new TimeSpan(11, 0, 0));
            student.AddCourse(mathCourse);
            student.AddCourse(physicsCourse);

            // Виводимо інформацію про студента та його розклад
            Console.WriteLine("Student information:");
            Console.WriteLine(student);

            Console.WriteLine("\nStudent schedule:");
            student.DisplaySchedule();

            try
            {
                mathCourse.ChangeTime(new TimeSpan(7, 30, 0));
                Console.WriteLine("\nNew student schedule after time change:");
                student.DisplaySchedule();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
