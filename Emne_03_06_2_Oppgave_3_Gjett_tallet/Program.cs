using System.Diagnostics;
using System.Linq.Expressions;

namespace Emne_03_06_2_Oppgave_3_Gjett_tallet
{
    internal class Program
    {
        // Oppgave: Gjett Tallet!
        //   Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100.
        //   Hver gang brukeren skriver inn et tall vil man få svar fra programmet om man må høyere eller lavere,
        //   helt til man gjetter riktig tall. Da skal man få spørsmål om man vil spille på nytt.
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("The Numb-Guessr Game!\nGuess a number between 1-100");

                var randomNumber = new Random();
                int randomValue = randomNumber.Next(0, 101);
                int userInput = -1;

                while (userInput != randomValue)
                {
                    string inputNumber = Console.ReadLine();

                    try
                    {
                        userInput = Convert.ToInt32(inputNumber);

                        if (userInput < randomValue)
                        {
                            Console.WriteLine("Gjett høyere!");
                        }
                        else if (userInput > randomValue)
                        {
                            Console.WriteLine("Gjett lavere!");
                        }
                        else
                        {
                            Console.WriteLine("Congratulations! You guessed the number.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Feil tastevalg. Skriv på nytt.");
                    }
                }
                bool validInput = false;
                while (!validInput)
                {
                        Console.WriteLine("Vil du spille igjen? [Y/N]");
                        string quitOrContinue = Console.ReadLine().ToUpper();
                        
                        if (quitOrContinue == "N")
                        {
                            Console.WriteLine("Takk for at du spilte. På gjensyn.");
                            playAgain = false;
                            validInput = true;
                        }
                        else if (quitOrContinue == "Y")
                        {
                            Console.WriteLine("La oss spille igjen!");
                            playAgain = true;
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Trykk 'Y' for å spille igjen, eller 'N' for å avslutte,");
                        }
                }
            }
        }
    }
}
