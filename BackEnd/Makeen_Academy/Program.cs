namespace Makeen_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to Makeen Academic System!\n");
            Console.ResetColor();

            Console.WriteLine("Please choose a service from the menu below:\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1.📚 Manage Courses & Books");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("- Add, edit, or delete courses easily.");
            Console.WriteLine("- View the list of available educational books.");
            Console.WriteLine("- Add new books or update existing ones.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("2.📝 Register for a Course");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("3.🧑‍⚕️ Book a Consultation");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("4.🛒 Purchase a Book");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("5.🗣️ Add Feedback");
            Console.ResetColor();

            Console.Write("\nEnter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nYou chose: Manage Courses & Books\n");
                    Console.ResetColor();

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("a. Add Course");
                    Console.WriteLine("b. Edit Course");
                    Console.WriteLine("c. Delete Course");
                    Console.WriteLine("d. View Courses");
                    Console.WriteLine("e. Add Book");
                    Console.WriteLine("f. Edit Book");
                    Console.WriteLine("g. Delete Book");
                    Console.WriteLine("h. View Books");
                    Console.Write("\nEnter your option: ");
                    string subChoice = Console.ReadLine();
                    Console.WriteLine($"\nYou selected option: {subChoice.ToUpper()} (Feature simulation in progress...)");
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nYou chose: Register for a Course");
                    Console.WriteLine("- Browse upcoming courses");
                    Console.WriteLine("- View course details");
                    Console.WriteLine("- Register for a batch by selecting a date");
                    Console.ResetColor();
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nYou chose: Book a Consultation");
                    Console.ResetColor();
                    Console.Write("Enter your purpose for consultation: ");
                    string purpose = Console.ReadLine();
                    Console.Write("Enter the trainer's name you want to book with: ");
                    string trainer = Console.ReadLine();
                    Console.WriteLine($"\nConsultation booked with {trainer} for: {purpose}");
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\nYou chose: Purchase a Book");
                    Console.ResetColor();
                    Console.WriteLine("- Browse available books");
                    Console.Write("Enter the name of the book you want to purchase: ");
                    string bookName = Console.ReadLine();
                    Console.WriteLine($"\nYou have successfully purchased: {bookName}");
                    break;

                case "5":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nYou chose: Add Feedback (Trainer Access Only)");
                    Console.ResetColor();
                    Console.Write("Enter Batch ID: ");
                    string batchId = Console.ReadLine();
                    Console.Write("Enter rating (1 to 5 stars): ");
                    string rating = Console.ReadLine();
                    Console.WriteLine($"\nFeedback submitted for Batch {batchId}: {rating} stars");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid choice. Please restart the application.");
                    Console.ResetColor();
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nThank you for using Makeen Academic System!");
            Console.WriteLine("We’re here to support your learning journey 🚀");
            Console.ResetColor();
        }
    }
}

