using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;




class Program
{

    static void Main()
    {

        Console.Title = "Guessing Game";
        string title = @"
 ______     __  __     ______     ______     ______     __     __   __     ______        ______     ______     __    __     ______    
/\  ___\   /\ \/\ \   /\  ___\   /\  ___\   /\  ___\   /\ \   /\ '-.\ \   /\  ___\      /\  ___\   /\  __ \   /\ '-./  \   /\  ___\   
\ \ \__ \  \ \ \_\ \  \ \  __\   \ \___  \  \ \___  \  \ \ \  \ \ \-.  \  \ \ \__ \     \ \ \__ \  \ \  __ \  \ \ \-./\ \  \ \  __\   
 \ \_____\  \ \_____\  \ \_____\  \/\_____\  \/\_____\  \ \_\  \ \_\\'\_\  \ \_____\     \ \_____\  \ \_\ \_\  \ \_\ \ \_\  \ \_____\ 
  \/_____/   \/_____/   \/_____/   \/_____/   \/_____/   \/_/   \/_/ \/_/   \/_____/      \/_____/   \/_/\/_/   \/_/  \/_/   \/_____/ ";
                                                                                                                                      
            Console.WriteLine(title);
           Console.WriteLine("");
int Gissning = 0;
int Bet = 0;
int Currency = 20;
int Exit = 1;
string answer;
while (Exit == 1)
{
int Done = 1;
Console.WriteLine("How much do you want to bet? You currently have" + " " + Currency + " " + "currency");
while (Done == 1)
{
  
    
     var Betin = Console.ReadLine();
     bool parseSuccess = int.TryParse(Betin, out Bet);
   if (parseSuccess)
   {
    
   }
   else
   {
    Console.WriteLine("Not a number");

   }
    if (Bet < 0)
    {
        Console.WriteLine("Can't bet a negative amount");
    }
    else if (Bet > Currency)
    {
        Console.WriteLine("Can't bet more than what you have");
    }
    else if (parseSuccess == true)
    {
        Currency -= Bet;
        Done = 0;
    }
} 
Random rnd = new Random();
int Nummer = rnd.Next(10);
Console.WriteLine("Guess right number between 0-9");
//if loop for guessing number

for (int i = 0; i < 4;)
{
    
    var Gissningin = Console.ReadLine();
     bool parseSuccess = int.TryParse(Gissningin, out Gissning);
   if (parseSuccess)
   {
    
   }
   else
   {
    Console.WriteLine("Not a number");

   }

if (Gissning > Nummer && parseSuccess == true)
{
    i++;
    Console.WriteLine("Guess is too high");
}
else if (Gissning < Nummer && parseSuccess == true)
{
    i++;
    Console.WriteLine("Guess is too low");
}

else
{
Console.WriteLine("Guess is right!");
Currency += Bet * 2;
i = 4;
}
if (i == 3)
{
    Console.WriteLine("Out of guesses, you lost!");
    i = 4;
}

}

Console.WriteLine();
Console.WriteLine("Want to play again?");
Console.WriteLine("y=yes n=no");
while(true)
{
    answer = Console.ReadLine();
    if (answer == "y" || answer == "Y")
    {
        break;
    }
    else if (answer == "n" || answer == "N")
    {
        Exit -= 1;
        break;
    }
    else
    {
        Console.WriteLine("Must write yes or no");
    }
}

if (Currency == 0)
{
    Console.WriteLine("Out of currency, closing the program");
    Console.ReadLine();
    Exit -= 1;
}
}

}
}