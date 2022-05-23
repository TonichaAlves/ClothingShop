using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class Program
    {
       
        public static string name = "";
        public static string password = "";
        public static string[] passwordOptions = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        public static decimal balance = 200;
        public static string userOption = "";
        public static readonly string[] allowedInput = { "0", "1", "2", "3", "4", "5", "e", };

        public static void CheckInput()
        {
            //this function checks user input using a boolean and while loop.  
            bool check = false;

            while (check == false)
            {

                // get user input 
                string userInput = Console.ReadLine();


                // run a foreach loop... compare user input to the values in our allowedinput array 
                foreach (string temp in allowedInput)
                {
                    // change our check boolean value from false to true based on user input   
                    check = userInput.Equals(temp);

                    //breaking out of the foreach loop if check equals true
                    if (check)
                    {
                        break;
                    }

                }//end of foreach loop



                //output displayed depending on users answers
                if (check)
                {
                    Console.WriteLine("\n \t Your input " + userInput + " is valid \n");
                    Console.WriteLine("\n \t *************************************************\n");
                }
                else
                {
                    Console.WriteLine("\n \t Your input " + userInput + " is not valid \n");
                    Console.WriteLine("\n \t *************************************************\n");
                }

                //calls the function of the number that the user enters.
                userOption = userInput;


            } // end of while loop



        }//end of CheckInput

        //function for begining of store (a welcome function) 
        public static void Start()
        {
            Console.WriteLine("\tWelcome to the clothes store\n\tPlease create a login\n");
            Console.WriteLine("\tEnter Name");
            name = Console.ReadLine();
            Console.WriteLine("\tPlease create a 4 digit Password");
            password = Console.ReadLine();

            Login();
        }





        //function for making a login name and password  
        static void Login()
        {
            string loginPass = "";
            Console.WriteLine("\t" + name + ", you have created an account \n \t Now please Login, using created Password");
            loginPass = Console.ReadLine();
            //Checks if users pasword is correct
            while (loginPass != password)
            {
                if (loginPass == password)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\tPassword Incorrect, please try again\n");
                    loginPass = Console.ReadLine();
                }
            }
            Console.WriteLine("\tAccepted\n");
            ClothingMenu();
        }




        //make function for store entrance and main clothing menu

        static void ClothingMenu()
        {
            Console.WriteLine("\n \t *************************************************\n");
            Console.WriteLine("\n\t Welcome to the Main Menu\n");
            Console.WriteLine("\n\t Your current balance is $" + balance);
            //Menu options displayed to user
            Console.WriteLine("\n\t\t To enter Jackets Press  1\n");
            Console.WriteLine("\t\t To enter Shirts Press 2\n");
            Console.WriteLine("\t\t To enter Pants Press 3\n");
            Console.WriteLine("\t\t To add more funds to your balance please press 4\n");
            Console.WriteLine("\t\t To go to cart press 5\n");

            CheckInput();
            //Code that links functions to user Input
            if (userOption == "1")
            {
                Jackets();
            }

            if (userOption == "2")
            {
                Shirts();
            }

            if (userOption == "3")
            {
                Pants();
            }

            if (userOption == "4")
            {
                Deposit();
            }

            if (userOption == "5")
            {
                End();
            }

        }

        static void Jackets()
        {
            //Jackets displayed to user
            Console.WriteLine("\n \t *************************************************\n");
            Console.WriteLine("\t***  Jackets  ***\n");
            Console.WriteLine("\t To buy a Jacket please type the corresponding number to add an item to your cart.\n");
            Console.WriteLine("\t\t 1 \t$50 Black Leather Jacket > 1\n");
            Console.WriteLine("\t\t 2 \t$70 Rain Jacket > 2\n");
            Console.WriteLine("\t\t 3 \t$40 Wool Jacket > 3\n");
            Console.WriteLine("\t\t 4 \t$20 Bomber Jacket > 4\n");
            Console.WriteLine("\t\t 5 \t$60 Puffer Jacket > 5\n");
            Console.WriteLine("\t\t***  To exit back to main menu please press > e  ***\n");

            CheckInput();

            if (userOption == "1")
            {
                decimal bljacket = 50;
                balance -= bljacket;

                Console.WriteLine("\t\t You have spent " + bljacket + " and added a Black Leather Jacket  to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Jackets();

            }


            if (userOption == "2")
            {
                decimal rain = 70;
                balance -= rain;

                Console.WriteLine("\t\t You have spent " + rain + " and added a Rain Jacket to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Jackets();
            }



            if (userOption == "3")
            {
                decimal wool = 40;
                balance -= wool;

                Console.WriteLine("\t\t You have spent " + wool + " and added a Wool Jacket to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Jackets();

            }



            if (userOption == "4")
            {
                decimal bomber = 20;
                balance -= bomber;

                Console.WriteLine("\t\t You have spent " + bomber + " and added a Bomber Jacket to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Jackets();

            }



            if (userOption == "5")
            {
                decimal puffer = 60;
                balance -= puffer;

                Console.WriteLine("\t\t You have spent " + puffer + " and added a Puffer Jacket to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Jackets();
            }



            if (userOption == "e")
            {
                ClothingMenu();
            }
        }//end of jacket function








        static void Shirts()
        {
            //Shirts displayed to user
            Console.WriteLine("\n \t *************************************************\n");
            Console.WriteLine("\t***  Shirts  ***\n");
            Console.WriteLine("\t To buy shirts please type the corresponding number to add an item to your cart.\n");
            Console.WriteLine("\t\t 1 \t$10 White shirt \n");
            Console.WriteLine("\t\t 2 \t$10 Yellow shirt \n");
            Console.WriteLine("\t\t 3 \t$20 Blue shirt \n");
            Console.WriteLine("\t\t 4 \t$20 Green shirt \n");
            Console.WriteLine("\t\t 5 \t$30 Black shirt \n");
            Console.WriteLine("\t\t***  To exit back to main menu please press > e  ***\n");

            CheckInput();

            if (userOption == "1")
            {
                decimal white = 10;
                balance -= white;

                Console.WriteLine("\t\t You have spent " + white + " and added a White shirt to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Shirts();

            }


            if (userOption == "2")
            {
                decimal yellow = 10;
                balance -= yellow;

                Console.WriteLine("\t\t You have spent " + yellow + " and added a Yellow shirt to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Shirts();
            }



            if (userOption == "3")
            {
                decimal blue = 20;
                balance -= blue;

                Console.WriteLine("\t\t You have spent " + blue + " and added a blue shirt to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Shirts();

            }



            if (userOption == "4")
            {
                decimal green = 20;
                balance -= green;

                Console.WriteLine("\t\t You have spent " + green + " and added a Green shirt to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Shirts();

            }



            if (userOption == "5")
            {
                decimal black = 30;
                balance -= black;

                Console.WriteLine("\t\t You have spent " + black + " and added a Black shirt to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Shirts();
            }



            if (userOption == "e")
            {
                ClothingMenu();
            }

        }//end of shirt function




        static void Pants()
        {
            //Pants displayed to user
            Console.WriteLine("\n \t *************************************************\n");
            Console.WriteLine("\t***  Pants  ***\n");
            Console.WriteLine("\t To buy a pair of pants please type the corresponding number to add an item to your cart.\n");
            Console.WriteLine("\t\t 1 \t$20 Brown Pants \n");
            Console.WriteLine("\t\t 2 \t$30 Tan Pants \n");
            Console.WriteLine("\t\t 3 \t$20 Blue Pants \n");
            Console.WriteLine("\t\t 4 \t$40 Grey Pants \n");
            Console.WriteLine("\t\t 5 \t$50 Black Pants\n");
            Console.WriteLine("\t\t***  To exit back to main menu please press > e  ***\n");

            CheckInput();


            if (userOption == "1")
            {
                decimal brown = 20;
                balance -= brown;

                Console.WriteLine("\t\t You have spent " + brown + " and added Brown Pants to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Pants();

            }


            if (userOption == "2")
            {
                decimal tan = 30;
                balance -= tan;

                Console.WriteLine("\t\t You have spent " + tan + " and added Tan Pants to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Pants();
            }



            if (userOption == "3")
            {
                decimal blue = 20;
                balance -= blue;

                Console.WriteLine("\t\t You have spent " + blue + " and added Blue Pants to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Pants();

            }



            if (userOption == "4")
            {
                decimal grey = 40;
                balance -= grey;

                Console.WriteLine("\t\t You have spent " + grey + " and added Grey Pants to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Pants();

            }



            if (userOption == "5")
            {
                decimal black = 50;
                balance -= black;

                Console.WriteLine("\t\t You have spent " + black + " and added Black Pants to your cart \n");

                Console.WriteLine("\t\t Your balance is now\t" + "$" + balance + "\n");

                Pants();
            }



            if (userOption == "e")
            {
                ClothingMenu();
            }


        }//end of pants function


        static void Deposit()
        {
            //Allows user to view current balance and deposit funds
            Console.WriteLine("\t Your balance is " + "$" + balance);
            Console.WriteLine("\n\n");


            Console.WriteLine("\t You can Deposit more Funds, please enter an amount.");


            decimal amount = 0;

            // amount = Convert.ToDecimal(Console.ReadLine());      //this is our bug 460

            if (decimal.TryParse(Console.ReadLine(), out amount))
            {
                balance += amount;
                Console.WriteLine("\t You deposited $" + amount + " your balance is now $" + balance + "\n\n");

            }

            else
            {
                Console.WriteLine("\t Invalid Amount \n\n");

            }

            ClothingMenu();

        }//end of deposit function


        //End/Cart funtion 
        static void End()
        {
            Console.WriteLine("\t*** Cart ***\n");
            Console.WriteLine("\tYour leftover balance is $" + balance);

            Console.WriteLine("\tThank you for shopping with us!");
            Console.WriteLine("\t\tGo back to Menu > 1");
            Console.WriteLine("\t\tTop up Balance > 2");
            Console.WriteLine("\t\tExit Program > 3");
            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                ClothingMenu();
            }

            if (userOption == "2")
            {
                Deposit();
            }

            if (userOption == "3")
            {
                Environment.Exit(0);
            }
        }




        static void Main(string[] args)
        {

            Start();
        }
    }
}