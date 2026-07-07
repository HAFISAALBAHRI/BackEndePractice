namespace E_CommerceWebsiteSystem1
{
    internal class Program
    {
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
                    //case 1:
                    //    RegisterUser();
                    //    break;

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

