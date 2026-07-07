using E_CommerceWebsiteSystem1.Models;
using Microsoft.EntityFrameworkCore;


namespace E_CommerceWebsiteSystem1
{
  
    internal class Program
    {
        static ECommerceContext context = new ECommerceContext();
        static void RegisterUser()
        {
            Console.WriteLine("========== Register New User ==========\n");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter Username: ");
                username = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(username))
                    break;

                attempts++;
                Console.WriteLine($"Invalid Username! Attempts left: {3 - attempts}");
            }

            if (attempts == 3)
            {
                Console.WriteLine("Too many invalid attempts. Returning to Main Menu...");
                return;
            }
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter Email: ");
                email = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(email) && email.Contains("@") && email.Contains("."))
                    break;

                attempts++;
                Console.WriteLine($"Invalid Email! Attempts left: {3 - attempts}");
            }

            if (attempts == 3)
            {
                Console.WriteLine("Too many invalid attempts. Returning to Main Menu...");
                return;
            }
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(password) && password.Length >= 6)
                    break;

                attempts++;
                Console.WriteLine($"Password must be at least 6 characters. Attempts left: {3 - attempts}");
            }

            if (attempts == 3)
            {
                Console.WriteLine("Too many invalid attempts. Returning to Main Menu...");
                return;
            }

            Console.Write("Enter Full Name: ");
            string fullName = Console.ReadLine();
            int attemptss = 0;

            while (attemptss < 3)
            {
                Console.Write("Enter Full Name (First Name and Family Name): ");
                fullName = Console.ReadLine()?.Trim();

                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    string[] names = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (names.Length >= 2)
                        break;
                }

                attemptss++;
                Console.WriteLine($"Please enter your first name and family name. Attempts left: {3 - attemptss}");
            }

            if (attemptss == 3)
            {
                Console.WriteLine("Too many invalid attempts. Returning to Main Menu...");
                return;
            }

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            // Check if username already exists
            User existingUser = context.Users
                .FirstOrDefault(u => u.Username == username);

            if (existingUser != null)
            {
                Console.WriteLine("\nUsername already exists.");
                return;
            }

            // Check if email already exists
            existingUser = context.Users
                .FirstOrDefault(u => u.Email == email);

            if (existingUser != null)
            {
                Console.WriteLine("\nEmail already exists.");
                return;
            }

            User newUser = new User
            {
                Username = username,
                Email = email,
                PasswordHash = password,
                FullName = fullName,
                PhoneNumber = phoneNumber,
                Address = address,
                RegistrationDate = DateTime.Now,
                IsActive = true
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            Console.WriteLine("\nUser registered successfully.");
            Console.WriteLine($"User ID: {newUser.UserId}");
        }
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n========================================");
                Console.WriteLine("      E-Commerce Management System");
                Console.WriteLine("========================================");
                Console.WriteLine(" 1  - Register New User");
                Console.WriteLine(" 2  - Add New Product");
                Console.WriteLine(" 3  - Place Order");
                Console.WriteLine(" 4  - Write Product Review");
                Console.WriteLine(" 5  - Update Product Price & Availability");
                Console.WriteLine(" 6  - Cancel Order");
                Console.WriteLine(" 7  - Delete Review");
                Console.WriteLine(" 8  - View All Products");
                Console.WriteLine(" 9  - Filter Products");
                Console.WriteLine(" 10 - View Category With Products");
                Console.WriteLine(" 11 - View Order History");
                Console.WriteLine(" 12 - Product Summary Report");
                Console.WriteLine(" 0  - Exit");
                Console.WriteLine("========================================");
                Console.Write("Select option: ");

                int option;

                while (!int.TryParse(Console.ReadLine(), out option) || option < 0 || option > 12)
                {
                    Console.Write("Invalid option. Please try again: ");
                }

                switch (option)
                {
                    case 1:
                        RegisterUser();
                        break;

                    //case 2:
                    //    AddProduct();
                    //    break;

                    //case 3:
                    //    PlaceOrder();
                    //    break;

                    //case 4:
                    //    WriteReview();
                    //    break;

                    //case 5:
                    //    UpdateProduct();
                    //    break;

                    //case 6:
                    //    CancelOrder();
                    //    break;

                    //case 7:
                    //    DeleteReview();
                    //    break;

                    //case 8:
                    //    ViewAllProducts();
                    //    break;

                    //case 9:
                    //    FilterProducts();
                    //    break;

                    //case 10:
                    //    GetCategoryWithProducts();
                    //    break;

                    //case 11:
                    //    ViewOrderHistory();
                    //    break;

                    //case 12:
                    //    ProductSummaryReport();
                    //    break;

                    case 0:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
    }

