using System;

namespace ModifiedDiamond
{
   class Program
   {
      static void Main(string[] args)
      {
         int userInput = 0;
         int rowAmount = 0;
         int x;
         int y;
         int z;
         char symbol = '*';


         Console.WriteLine("Please choose what kind of character to display:");
         Console.WriteLine("1 for *, 2 for !, 3 for $, 4 for %");
         userInput = Convert.ToInt32(Console.ReadLine());


         while (userInput != 0)
         {
            while (userInput < 1 || userInput > 4)
            {
               Console.WriteLine("Please choose a number between 1 and 4 to choose your symbol choice.");
               userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput == 1)
            {
               symbol = '*';
               Console.WriteLine("You have selected a *");
            }

            if (userInput == 2)
            {
               symbol = '!';
               Console.WriteLine("You have selected a !");
            }
            else if (userInput == 3)
            {
               symbol = '$';
               Console.WriteLine("You have selected a $");
            }
            else if (userInput == 4)
            {
               symbol = '%';
               Console.WriteLine("You have selected a %");
            }
            Console.WriteLine(symbol);

            Console.WriteLine("How many rows would you like in your diamond? (Please choose an odd number between 1 and 19");
            rowAmount = Convert.ToInt32(Console.ReadLine());

            while (rowAmount != 0)
            {
               while (rowAmount < 0 || rowAmount > 19 || ((rowAmount % 2) == 0))
               {
                  Console.WriteLine("Please type in an odd number for your number of rows.");
                  rowAmount = Convert.ToInt32(Console.ReadLine());
               }

               for (x = 0; x <= rowAmount; x++)
               {
                  for (y = 0; y < rowAmount - x; y++)
                  {
                     Console.Write(' ');
                  }
                  for (z = 1; z <= 2 * x - 1; z++)
                  {
                     Console.Write(symbol);
                  }
                  Console.WriteLine();

               }

               for (x = rowAmount - 1; x >= 1; x--)
               {
                  for (y = 1; y <= rowAmount - x; y++)
                  {
                     Console.Write(' ');
                  }
                  for (z = 1; z <= 2 * x - 1; z++)
                  {
                     Console.Write(symbol);
                  }
                  Console.WriteLine();

               }
               break;


            }
            Console.WriteLine("What symbol would you like to use? (1 for *, 2 for !, 3 for $, 4 for % (0 to exit)");

            userInput = Convert.ToInt32(Console.ReadLine());
         }



      }

   }
}




