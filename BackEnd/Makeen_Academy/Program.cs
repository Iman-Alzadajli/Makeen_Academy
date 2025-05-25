namespace Makeen_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to Makeen Academic System!\n");
            Console.ResetColor();

            Console.WriteLine("Please choose a section to manage:\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1. 👥 Manage Customers");
            Console.WriteLine("2. 📚 Manage Books");
            Console.WriteLine("3. 🛒 Purchase Operations");
            Console.WriteLine("4. 📝 Manage Courses & Batches");
            Console.WriteLine("5. 🧑‍⚕️ Manage Consultations");
            Console.WriteLine("6. 👨‍🏫 Manage Trainers");
            Console.WriteLine("7. ❌ Exit System");
            Console.ResetColor();

            Console.Write("\nEnter your choice (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n👥 Customer Management Options:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new user");
                    Console.WriteLine("2 - Display all users");
                    Console.WriteLine("3 - Delete user");
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n📚 Book Management Options:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Display all books");
                    Console.WriteLine("2 - Add new book");
                    Console.WriteLine("3 - Update book");
                    Console.WriteLine("4 - Search book");
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n🛒 Purchase Operations:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Select book to buy");
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n📝 Course & Batch Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Display all courses");
                    Console.WriteLine("2 - Register customer to course");
                    Console.WriteLine("3 - Remove batch");
                    Console.WriteLine("4 - Add new course");
                    Console.WriteLine("5 - Add new batch");
                    break;

                case "5":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n🧑‍⚕️ Consultation Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new consultation");
                    Console.WriteLine("2 - Display all consultations");
                    break;

                case "6":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n👨‍🏫 Trainer Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new trainer");
                    Console.WriteLine("2 - Display all trainers");
                    Console.WriteLine("3 - Update trainer information");
                    Console.WriteLine("4 - Remove trainer");
                    break;

                case "7":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nExiting Makeen Academic System. Goodbye!");
                    Console.ResetColor();
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please restart the application.");
                    Console.ResetColor();
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nThank you for using Makeen Academic System!");
            Console.ResetColor();
        }
    }
}

