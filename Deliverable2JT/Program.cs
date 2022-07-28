namespace Deliverable2
{
    public class Program
    {
        public static void Main()
        {
            int patron;

            string D1, D2, D3, D4, D5, D6;

            int C1, C2, C3, C4, C5, C6;

            char s;

            int total = 0;

            Console.WriteLine("Welcome to the Buffet. It is all you can eat, $9.99 person. How many persons are in your party?");
            patron = Convert.ToInt32(Console.ReadLine());
            if (patron >= 1 && patron <= 6)
            {
                Console.WriteLine("Alright, a table for {0} persons, right this way.", +patron);
                Console.WriteLine();
                goto part2;
            }
            else if (patron > 6)
            {
                Console.WriteLine("We are not able to seat more than 6 people at this time, please come back later");
                return;
            }

        part2:;
            Console.WriteLine("In the meantime, how many drinks would you like to order? Due to shortages, we only have water and soda available right now. Water is provided free, soda is $1.50 each. I will get a water for anybody who doesn't want a soda.");
            Console.WriteLine();
            goto part3;

        part3:;
            if (patron == 1)
            {
                Console.WriteLine("Person #1? Water or Soda?");
                D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                
                Console.WriteLine();
                goto part4;
            }
                else if (patron == 2)
                {
                Console.WriteLine("Person #1? Water or Soda?");
                D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #2?");
                D2 = Convert.ToString(Console.ReadLine());
                if (D2 == "water")
                {
                    C2 = 0;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 == "soda")
                {
                    C2 = 1;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                goto part4;
                }
                else if (patron == 3)
                {
                Console.WriteLine("Person #1? Water or Soda?");
                D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #2?");
                D2 = Convert.ToString(Console.ReadLine());
                if (D2 == "water")
                {
                    C2 = 0;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 == "soda")
                {
                    C2 = 1;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #3?");
                D3 = Convert.ToString(Console.ReadLine());
                if (D3 == "water")
                {
                    C3 = 0;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 == "soda")
                {
                    C3 = 1;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                goto part4;
            }
                else if (patron == 4)
                {
                Console.WriteLine("Person #1? Water or Soda?");
                D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #2?");
                D2 = Convert.ToString(Console.ReadLine());
                if (D2 == "water")
                {
                    C2 = 0;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 == "soda")
                {
                    C2 = 1;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #3?");
                D3 = Convert.ToString(Console.ReadLine());
                if (D3 == "water")
                {
                    C3 = 0;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 == "soda")
                {
                    C3 = 1;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #4?");
                D4 = Convert.ToString(Console.ReadLine());
                if (D4 == "water")
                {
                    C4 = 0;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 == "soda")
                {
                    C4 = 1;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                goto part4;
                }
                else if (patron == 5)
            {
                Console.WriteLine("Person #1? Water or Soda?");
                D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #2?");
                D2 = Convert.ToString(Console.ReadLine());
                if (D2 == "water")
                {
                    C2 = 0;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 == "soda")
                {
                    C2 = 1;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #3?");
                D3 = Convert.ToString(Console.ReadLine());
                if (D3 == "water")
                {
                    C3 = 0;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 == "soda")
                {
                    C3 = 1;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #4?");
                D4 = Convert.ToString(Console.ReadLine());
                if (D4 == "water")
                {
                    C4 = 0;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 == "soda")
                {
                    C4 = 1;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #5?");
                D5 = Convert.ToString(Console.ReadLine());
                if (D5 == "water")
                {
                    C5 = 0;
                    total = total + C5;
                    Console.Write("Okay, one ");
                    Console.Write(D5 + ".");
                }
                else if (D5 == "soda")
                {
                    C5 = 1;
                    total = total + C5;
                    Console.Write("Okay, one ");
                    Console.Write(D5 + ".");
                }
                else if (D5 != "")
                {
                    Console.WriteLine("We don't have that drink sorry. I'll get you a water.");
                }
                Console.WriteLine();
                goto part4;

                }
                else if (patron == 6)
                {
                    Console.WriteLine("Person #1? Water or Soda?");
                    D1 = Convert.ToString(Console.ReadLine());
                if (D1 == "water")
                {
                    C1 = 0;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 == "soda")
                {
                    C1 = 1;
                    total = total + C1;
                    Console.Write("Okay, one ");
                    Console.Write(D1 + ".");
                }
                else if (D1 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                    Console.WriteLine("Person #2?");
                    D2 = Convert.ToString(Console.ReadLine());
                if (D2 == "water")
                {
                    C2 = 0;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 == "soda")
                {
                    C2 = 1;
                    total = total + C2;
                    Console.Write("Okay, one ");
                    Console.Write(D2 + ".");
                }
                else if (D2 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                    Console.WriteLine("Person #3?");
                    D3 = Convert.ToString(Console.ReadLine());
                if (D3 == "water")
                {
                    C3 = 0;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 == "soda")
                {
                    C3 = 1;
                    total = total + C3;
                    Console.Write("Okay, one ");
                    Console.Write(D3 + ".");
                }
                else if (D3 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #4?");
                    D4 = Convert.ToString(Console.ReadLine());
                if (D4 == "water")
                {
                    C4 = 0;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 == "soda")
                {
                    C4 = 1;
                    total = total + C4;
                    Console.Write("Okay, one ");
                    Console.Write(D4 + ".");
                }
                else if (D4 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                Console.WriteLine("Person #5?");
                    D5 = Convert.ToString(Console.ReadLine());
                if (D5 == "water")
                {
                    C5 = 0;
                    total = total + C5;
                    Console.Write("Okay, one ");
                    Console.Write(D5 + ".");
                }
                else if (D5 == "soda")
                {
                    C5 = 1;
                    total = total + C5;
                    Console.Write("Okay, one ");
                    Console.Write(D5 + ".");
                }
                else if (D5 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                    Console.WriteLine("Person #6?");
                    D6 = Convert.ToString(Console.ReadLine());
                if (D6 == "water")
                {
                    C6 = 0;
                    total = total + C6;
                    Console.Write("Okay, one ");
                    Console.Write(D6 + ".");
                }
                else if (D6 == "soda")
                {
                    C6 = 1;
                    total = total + C6;
                    Console.Write("Okay, one ");
                    Console.Write(D6 + ".");
                }
                else if (D6 != "")
                {
                    Console.WriteLine("We don't have that drink sorry.");
                }
                Console.WriteLine();
                goto part4;
                }

        part4:;
            Console.WriteLine("The buffet is open, please take your food whenever you are ready.");
            Console.WriteLine();

            Console.WriteLine("Here are your {0} sodas", + total);
            Console.WriteLine("And {0} waters", + patron-total);

            double bill = 9.99 * patron + total*1.50;

            Console.WriteLine("Your total bill is ${0}. Thank you for coming!", + bill);
            }
        }
    }
