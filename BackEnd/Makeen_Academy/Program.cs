using Makeen_Academy.Context;
using Makeen_Academy.Models;

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
                case "1": //customer start here 
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n👥 Customer Management Options:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new customer");
                    Console.WriteLine("2 - Display all customers");
                    Console.WriteLine("3 - Delete customer");

                    Console.Write("\nChoose an option (1-3): ");
                    string customerChoice = Console.ReadLine();

                    using (var context = new ApplicationDbContext())
                    {
                        switch (customerChoice)
                        {
                            case "1":
                                Console.Write("Enter Customer Name: ");
                                string name = Console.ReadLine();

                                Console.Write("Enter Customer Email: ");
                                string email = Console.ReadLine();

                                Console.Write("Enter Customer Phone: ");
                                string phone = Console.ReadLine();

                                var newCustomer = new Customer
                                {
                                    Name = name,
                                    Email = email,
                                    PhoneNumber = phone
                                };

                                context.Customers.Add(newCustomer);
                                context.SaveChanges();

                                Console.WriteLine("\n✅ Customer added successfully to the database.");
                                break;

                            case "2":
                                Console.WriteLine("\n📋 List of all customers:");
                                var customers = context.Customers.ToList();
                                foreach (var c in customers)
                                {
                                    Console.WriteLine($"ID: {c.Id} | Name: {c.Name} | Email: {c.Email} | Phone: {c.PhoneNumber}");
                                }
                                break;

                            case "3":
                                Console.Write("Enter Customer ID to delete: ");
                                if (int.TryParse(Console.ReadLine(), out int deleteId))
                                {
                                    var customerToDelete = context.Customers.Find(deleteId);
                                    if (customerToDelete != null)
                                    {
                                        context.Customers.Remove(customerToDelete);
                                        context.SaveChanges();
                                        Console.WriteLine("✅ Customer deleted successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("❌ Customer not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("❌ Invalid ID format.");
                                }
                                break;

                            default:
                                Console.WriteLine("❌ Invalid option.");
                                break;
                        }
                    }
                    break; //customer end here


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

                case "4": // course start here
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n📝 Course & Batch Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Display all courses");
                    Console.WriteLine("2 - Register customer to course");
                    Console.WriteLine("3 - Remove batch");
                    Console.WriteLine("4 - Add new course");
                    Console.WriteLine("5 - Add new batch");

                    Console.Write("\nChoose an option (1-5): ");
                    string courseChoice = Console.ReadLine();

                    using (var context = new ApplicationDbContext())
                    {
                        switch (courseChoice)
                        {
                            case "1":
                                Console.WriteLine("\n📋 List of Courses:");
                                var allCourses = context.Courses.ToList();
                                foreach (var c in allCourses)
                                {
                                    Console.WriteLine($"ID: {c.Id} | Name: {c.Name}");
                                }
                                break;

                            case "2":
                                Console.WriteLine("\n⚠️ Feature not implemented yet (Register customer to course).");
                                break;

                            case "3":
                                Console.Write("Enter Batch ID to remove: ");
                                if (int.TryParse(Console.ReadLine(), out int batchId))
                                {
                                    var batchToRemove = context.Batches.Find(batchId);
                                    if (batchToRemove != null)
                                    {
                                        context.Batches.Remove(batchToRemove);
                                        context.SaveChanges();
                                        Console.WriteLine("✅ Batch removed successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("❌ Batch not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("❌ Invalid Batch ID format.");
                                }
                                break;

                            case "4":
                                Console.Write("Enter Course Name: ");
                                string courseName = Console.ReadLine();

                                var newCourse = new Course
                                {
                                    Name = courseName
                                };

                                try
                                {
                                    context.Courses.Add(newCourse);
                                    context.SaveChanges();
                                    Console.WriteLine("✅ New course added.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("❌ Error while saving course:");
                                    Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                                }
                                break;

                            case "5":
                                try
                                {
                                    Console.Write("Enter Start Date (yyyy-MM-dd): ");
                                    DateTime startDate = DateTime.Parse(Console.ReadLine());

                                    Console.Write("Enter End Date (yyyy-MM-dd): ");
                                    DateTime endDate = DateTime.Parse(Console.ReadLine());

                                    Console.Write("Enter Trainer ID: ");
                                    int trainerId = int.Parse(Console.ReadLine());

                                    Console.Write("Enter Course ID: ");
                                    int courseId = int.Parse(Console.ReadLine());

                                    var courseExists = context.Courses.Any(c => c.Id == courseId);
                                    var trainerExists = context.Trainers.Any(t => t.Id == trainerId);

                                    if (!courseExists || !trainerExists)
                                    {
                                        Console.WriteLine("❌ Invalid Course ID or Trainer ID. Please check and try again.");
                                        break;
                                    }

                                    var newBatch = new Batch
                                    {
                                        Start_Date = startDate,
                                        End_Date = endDate,
                                        TrainerId = trainerId,
                                        CourseId = courseId,
                                        Review = "" // Provide default value to avoid NOT NULL issues
                                    };

                                    context.Batches.Add(newBatch);
                                    context.SaveChanges();
                                    Console.WriteLine("✅ New batch added.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("❌ Error while saving batch:");
                                    Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                                }
                                break;

                            default:
                                Console.WriteLine("❌ Invalid option.");
                                break;
                        }
                    }
                    break; // course end here



                case "5": //start of Consultations
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n🧑‍⚕️ Consultation Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new consultation");
                    Console.WriteLine("2 - Display all consultations");

                    Console.Write("\nChoose an option (1-2): ");
                    string consultationChoice = Console.ReadLine();

                    using (var context = new ApplicationDbContext())
                    {
                        switch (consultationChoice)
                        {
                            case "1":
                                try
                                {
                                    Console.Write("Enter Customer ID: ");
                                    int customerId = int.Parse(Console.ReadLine());

                                    Console.Write("Enter Trainer ID: ");
                                    int trainerId = int.Parse(Console.ReadLine());

                                    Console.Write("Enter Purpose: ");
                                    string purpose = Console.ReadLine();

                                    Console.Write("Enter Topic: ");
                                    string topic = Console.ReadLine();

                                    Console.Write("Enter Consultation Date (yyyy-MM-dd): ");
                                    DateTime date = DateTime.Parse(Console.ReadLine());

                                    var customerExists = context.Customers.Any(c => c.Id == customerId);
                                    var trainerExists = context.Trainers.Any(t => t.Id == trainerId);

                                    if (!customerExists || !trainerExists)
                                    {
                                        Console.WriteLine("❌ Invalid Customer ID or Trainer ID.");
                                        break;
                                    }

                                    var newConsultation = new Consultation
                                    {
                                        CustomerId = customerId,
                                        TrainerId = trainerId,
                                        Purpose = purpose,
                                        Topic = topic,
                                        Date = date
                                    };

                                    context.Consultations.Add(newConsultation);
                                    context.SaveChanges();
                                    Console.WriteLine("✅ Consultation added successfully.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("❌ Error while saving consultation:");
                                    Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                                }
                                break;


                            case "2":
                                Console.WriteLine("\n📋 List of Consultations:");
                                var consultations = context.Consultations.ToList();
                                foreach (var cons in consultations)
                                {
                                    Console.WriteLine($"ID: {cons.Id} | Customer ID: {cons.CustomerId} | Trainer ID: {cons.TrainerId} | Date: {cons.Date.ToShortDateString()} | Purpose: {cons.Purpose}");
                                }
                                break;

                            default:
                                Console.WriteLine("❌ Invalid option.");
                                break;
                        }
                    }
                    break; //end of Consultations


                case "6": //trainer start here
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n👨‍🏫 Trainer Management:");
                    Console.ResetColor();
                    Console.WriteLine("1 - Add new trainer");
                    Console.WriteLine("2 - Display all trainers");
                    Console.WriteLine("3 - Update trainer information");
                    Console.WriteLine("4 - Remove trainer");

                    Console.Write("\nChoose an option (1-4): ");
                    string trainerChoice = Console.ReadLine();

                    using (var context = new ApplicationDbContext())
                    {
                        switch (trainerChoice)
                        {
                            case "1":
                                Console.Write("Enter Trainer Name: ");
                                string tName = Console.ReadLine();

                                Console.Write("Enter Trainer Email: ");
                                string tEmail = Console.ReadLine();

                                Console.Write("Enter Trainer Phone: ");
                                string tPhone = Console.ReadLine();

                                var newTrainer = new Trainer
                                {
                                    Name = tName,
                                    Email = tEmail,
                                    PhoneNumber = tPhone
                                };

                                context.Trainers.Add(newTrainer);
                                context.SaveChanges();
                                Console.WriteLine("✅ Trainer added successfully.");
                                break;

                            case "2":
                                Console.WriteLine("\n📋 List of Trainers:");
                                var allTrainers = context.Trainers.ToList();
                                foreach (var t in allTrainers)
                                {
                                    Console.WriteLine($"ID: {t.Id} | Name: {t.Name} | Email: {t.Email} | Phone: {t.PhoneNumber}");
                                }
                                break;

                            case "3":
                                Console.Write("Enter Trainer ID to update: ");
                                if (int.TryParse(Console.ReadLine(), out int updateId))
                                {
                                    var trainerToUpdate = context.Trainers.Find(updateId);
                                    if (trainerToUpdate != null)
                                    {
                                        Console.Write("Enter new name: ");
                                        trainerToUpdate.Name = Console.ReadLine();

                                        Console.Write("Enter new email: ");
                                        trainerToUpdate.Email = Console.ReadLine();

                                        Console.Write("Enter new phone number: ");
                                        trainerToUpdate.PhoneNumber = Console.ReadLine();

                                        context.SaveChanges();
                                        Console.WriteLine("✅ Trainer updated successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("❌ Trainer not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("❌ Invalid ID format.");
                                }
                                break;

                            case "4":
                                Console.Write("Enter Trainer ID to remove: ");
                                if (int.TryParse(Console.ReadLine(), out int removeId))
                                {
                                    var trainerToRemove = context.Trainers.Find(removeId);
                                    if (trainerToRemove != null)
                                    {
                                        context.Trainers.Remove(trainerToRemove);
                                        context.SaveChanges();
                                        Console.WriteLine("✅ Trainer removed successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("❌ Trainer not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("❌ Invalid ID format.");
                                }
                                break;

                            default:
                                Console.WriteLine("❌ Invalid option.");
                                break;
                        }
                    }
                    break; //end of trainer


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

