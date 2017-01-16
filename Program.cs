using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dos_Dos
{
    class Program
    {
        static void Main(string[] args)
        {


            bool stop = false;


            while (stop == false)
            {

                Console.WriteLine("What is your first name ");
                string firstName = (Console.ReadLine());

                if (firstName == "quit" || firstName == "exit")
                {
                    break;
                }
                else if (firstName == "restart")

                {
                    continue;
                }
                Console.WriteLine("What is last name ");
                string lastName = (Console.ReadLine());

                if (lastName == "quit" || lastName == "exit")
                {
                    break;
                }
                else if (lastName == "restart")

                {
                    continue;
                }

                greetFriend(firstName, lastName);

                Console.WriteLine("What is your age");

                string old = Console.ReadLine();


                if (old == "quit" || old == "exit")
                {
                    break;
                }
                else if (old == "restart")
                {
                    continue;
                }

                int age = int.Parse(old);

                int overdaHill = OverdaHill(age);


                Console.WriteLine("What is your numerical birth month");

                string solds = Console.ReadLine();


                if (solds == "quit" || solds == "exit")
                {
                    break;
                }
                else if (solds == "restart")

                {
                    continue;
                }
                int month = int.Parse(solds);



                Console.WriteLine("What is your favorite ROYGBIV color,if you don't know what a ROYGBIV color is type HELP");
                string roygbiv = (Console.ReadLine());

                if (roygbiv == "quit" || roygbiv == "exit")
                {
                    break;
                }
                else if (roygbiv == "restart")

                {
                    continue;
                }
                if (roygbiv == "help")
                {
                    Console.WriteLine("If you do not know what ROYGBIV colors they are one of the following \n red, \n orange, \n yellow,\n green, \n blue,\n indigo, \n violet");
                    roygbiv = (Console.ReadLine());

                    if (roygbiv == "quit" || roygbiv == "exit")
                    {
                        break;
                    }
                    else if (roygbiv == "restart")

                    {
                        continue;
                    }
                }
                roygbiv.ToLower();


                Console.WriteLine("How many siblings do you have");

                string kids = Console.ReadLine();
                if (kids == "quit" || kids == "exit")
                {
                    break;
                }
                else if (kids == "restart")

                {
                    continue;
                }
                int siblings = int.Parse(kids);

                double bank = 0;

                double birth = yenom(month);
                int growUp = OverdaHill(age);
                string homes = casa(siblings);
                string blue = rainbowBlu(roygbiv);


                Console.WriteLine(firstName + " " + lastName + " " + "You will retire in " + " " + growUp + " " + "years "+ " " + " and have " + " " + "$" + birth + " " + "dollars in the bank, " + homes + "and your ride is a " + blue);


                futureTells();
                stop = true;
            }



        }




        static void greetFriend(string firstName, string lastName)

        {

            Console.WriteLine("Greetings your Excellancy" + " " + firstName + " " + lastName + " " + "I will tell you your fortune!");
        }
        static int OverdaHill(int age)
        {
            int retire;
            if (age % 2 == 0)
            {
                retire = 30;
            }
            else
            {
                retire = 1;

            }
            return retire;
        }
        static string casa(int siblings)
        {
            string vacay = "";
            if (siblings == 0)

            {
                vacay = "You have a vacation home in Florida ";
            }

            else if (siblings == 1)

            {

                vacay = "You have a vaction home in Mexico ";
            }


            else if (siblings == 2)

            {
                vacay = "You have a vacation home in Germany ";
            }


            else if (siblings == 3)

            {
                vacay = "You have a vacation home in Dubai ";
            }


            else if (siblings == 3)


            {

                vacay = "You have a vaction home in Tha CLEVE ";
            }
            else if (siblings >= 4)
            {

                vacay = "You have a vaction home in Iraq ";
            }

            return vacay;
        }
        static string rainbowBlu(string roygbiv)
        {
            string ride = "";
            if (roygbiv == "red")

            {
                ride = "boat ";

            }


            else if (roygbiv == "orange")

            {
                ride = "car ";
            }


            else if (roygbiv == "yellow")

            {
                ride = "bike ";
            }


            else if (roygbiv == "green")

            {
                ride = "scooter ";
            }


            else if (roygbiv == "blue")

            {
                ride = "skates ";

            }


            else if (roygbiv == "indigo")

            {
                ride = " plane ";

            }


            else if (roygbiv == "violet")

            {
                ride = " spaceship ";
            }
            else if (roygbiv == "")
            {
                ride = "squeaky shopping cart ";
            }
            return ride;
        }

        static double yenom(int month)
        {
            double bank = 0;

            if (month < 5 && month > 0)

            {
                bank = 100000;
            }

            if (month <= 8 && month >= 5)
            {
                bank = 500000;
            }
            if (month > 8 && month <= 12)
            {
                bank = 1500000000;
            }
            if (month <= 0)
            {
                bank = 0;
            }
            return bank;
        }
        static void futureTells()
        {

            Console.WriteLine("That's a great fortune and  all, but your lucky to be alive! ");
        }
    }
}
