using System;

namespace Assessment
{
    class Membership
    {
        static void Main(string[] args)
        {
            string[] names = new string[6]; //storing names in string
            int[] month = new int[6]; //storing month in number
            char[] offer = new char[6]; // storing offer if y/n
            double[] fee = new double[6]; // storing fee value in decimal
            int i = 0; //count 

            //Displaying Message with user: your name

            Console.WriteLine("Welcome to the Membership Management Platform");
            Console.WriteLine("User: Sushil Shakya \n");


            //Using while loop as true if they choose option1,2,0 to initialise loops inside it
            //Or else system won't run and crash

            while (true)
            {

                //Descriptions for users to choose options 

                Console.WriteLine("\nPlease check the options below:");
                Console.WriteLine("1 - Create new membership");
                Console.WriteLine("2 - Show summary information");
                Console.WriteLine("0 - Quit\n");
                Console.Write("Choose your option: ");

                int option = Convert.ToInt32(Console.ReadLine()); //Storing option as an int to connect it with loops

                //If user choose Option 1 ------------------------------------------

                if (option == 1) 
                {
                    Console.Write("Please enter the customer name: ");
                    string name = Console.ReadLine(); //Storing name as string 

                    Console.Write("Please enter the number of months for the new membership: ");
                    int months = Convert.ToInt32(Console.ReadLine()); //Storing months as int equiv to 32 bits

                    //While loop to confirm months within range 1-60 with its relative fee
                    while (months < 1 || months > 60) 
                    {
                        Console.WriteLine("Invalid Range."); //Warning msg for below 1 and above 60 value
                        Console.Write("Please enter the number of months for the new membership: "); 
                        months = Convert.ToInt32(Console.ReadLine());
                    }

                    double cost = 0; //storing fee as cost to use in if-else statement 
                    double discount = 0; //storing discount if customer choose offer as Y

                    //for members choosing months between 1 and 11, fee i.e; cost is 40 PM
                    //Aditionally total cost is calculated multiplying cost with months entered

                    if (months >= 1 && months <= 11)
                    {
                        cost = 40.0 * months;
                    }

                    //for members choosing months between 12 and 23, Cost is 37.5 PM

                    else if (months >= 12 && months <= 23)
                    {
                        cost = 37.5 * months;
                    }

                    //for members choosing months greater than or equals to 24, Cost is 35 PM
                    else
                    {
                        if (months >= 24)
                        {
                            cost = 35.0 * months;
                        }
                    }

                    //Asking user if they receive a special offer or not
                    Console.Write("Special offer granted? (Y/N): ");
                    char ch = Console.ReadLine()[0];
                    ch = char.ToUpper(ch); //any char value converting it to uppercase 

                    //if member choose y/Y then discount is calculated
                    //With Formula discount = cost * 15 %
                    //Or else we can directly make cost = cost * 0.85

                    if (ch == 'Y')
                    {
                        discount = cost * 0.15;
                    }
                    else
                    {
                        discount = 0;
                    }

                    //Finding out total cost if we used discount
                    cost = cost - discount;

                    //Summary details of data provided
                    Console.WriteLine("Membership for " + name + " has been created.");
                    Console.WriteLine("The membership fee is " + cost + ".");
                    Console.WriteLine("----------------------------------------------");

                    //data count begining with i = 0
                    names[i] = name;
                    month[i] = months;
                    offer[i] = ch;
                    fee[i] = cost;
                }

                //If user choose Option 2 ------------------------------------------

                else if (option == 2)
                {

                    //Headlines 
                    Console.WriteLine("Summary of Memberships");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Name\t\tMonths\t\tOffer\t\tFee");
                    Console.WriteLine("----------------------------------------------");

          
                    //data types top header with its count starting at j = 0

                    for (int j = 0; j < names.Length; j++)
                    {
                        Console.WriteLine(names[j] + "\t\t" + month[j] + "\t\t" + offer[j] + "\t\t" + fee[j]);
                    }

                    Console.WriteLine("----------------------------------------------");

                    
                    double max = fee[0], min = fee[0]; //storing max and min
                    string most = names[0], least = names[0]; //storing names of most and least equivalent to max and min fees

                    //using for loop with if condition 

                    for (int j = 0; j < names.Length; j++)
                    {
                        //if fee is max
                        if (fee[j] > max)
                        {
                            max = fee[j];
                            most = names[j];
                        }

                        //if fee is min
                        if (fee[j] < min)
                        {
                            min = fee[j];
                            least = names[j];
                        }
                    }


                    //Summary of members with most and least expenses.
                    Console.WriteLine("The customer spends the most is " + most + " at " + max);
                    Console.WriteLine("The customer spends the least is " + least + " at " + min);
                    Console.WriteLine("----------------------------------------------");
                }

                //If user choose Option 3 ------------------------------------------
               
                else
                {
                    if (option == 0)
                    {
                        break; //Stops terminal & breaking out of loop
                    }
                }
                i++; //starting new loop again
            }
        }
    }
}
            









