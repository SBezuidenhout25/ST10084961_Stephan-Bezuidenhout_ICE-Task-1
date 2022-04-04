using System;
using System.Windows.Input;

namespace prjExcersise11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_ORDER = 5;
            const double VAT = 0.14;
          
            Console.WriteLine("Welcome to the program!!!");

                try
                {
                    while (true)
                    {
                        cart crt1 = new cart(MIN_ORDER);
                        for (int x = 0; x < MIN_ORDER; x++)
                        {
                            items item = new items();
                            Console.WriteLine("\nProgram: Please enter the name of item number " + (x + 1) + " of " + MIN_ORDER + " or 'exit' to exit the program");
                            Console.Write("You: ");
                            item.itemName = Console.ReadLine();                    
                            if (item.itemName.ToLower().Equals("exit"))
                            {
                                System.Environment.Exit(0);
                            }
              
                            Console.WriteLine("Program: Please enter the price of item number " + (x + 1) + " of " + MIN_ORDER);
                            Console.Write("You: R");
                            item.itemPrice = Convert.ToDouble(Console.ReadLine());
                            item.itemVat = VAT;
                            crt1.storeInCart(item.itemName, item.itemPrice, x, item.itemVat);
                        }
                        Console.WriteLine(crt1.ToString());
                    }
                System.Environment.Exit(0);
                }
                catch (FormatException )
                {
                    Console.WriteLine("Please enter the item price in the following format: # or #,##");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            

        }
        
    }
}
