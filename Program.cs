using System;
// using Card;

namespace DeckofCards
{



    public class Program
    {
        public static void Main(string[] args)
        {
            //Less calls to Console this way!
            Console.WriteLine("\n\n\nAre you Bold Enough to Play? - Type Y to Play the Toledo Panic Button");
            string InputLine = Console.ReadLine();
            //One conditional when using ToLower call
            while (InputLine.ToLower() == "y" ) {
                //Create after you know they are actually going to play
                Deck myDeck = new Deck();
                myDeck.shuffle();

                Player player1 = new Player("Dave");
                Player player2 = new Player("Computer");
                player1.Deal(myDeck);
                player2.Deal(myDeck);
                Console.WriteLine("\n\n\n\nAllie has " + player1.hand[0]);
                Console.WriteLine("\nSeth has " + player2.hand[0] + "\n\n");

                if (player1.hand[0].numVal > player2.hand[0].numVal) {
                    Console.WriteLine("Allie wins!");
                    player1.hand.RemoveAt(0);
                    player2.hand.RemoveAt(0);
                    Console.WriteLine("");
                }
           
                else if (player1.hand[0].numVal < player2.hand[0].numVal) {
                    Console.WriteLine("Seth wins!");
                    player1.hand.RemoveAt(0);
                    player2.hand.RemoveAt(0);
                    Console.WriteLine("");    
                }

                else { Console.WriteLine("There's a tie! Play Again!");
                    player1.hand.RemoveAt(0);
                    player2.hand.RemoveAt(0);
                    Console.WriteLine("");
                }

                Console.WriteLine("\nAre you Bold Enough to Play? - Type Y to Play the Toledo Panic Button");
                InputLine = Console.ReadLine();
            }
            Console.WriteLine("You Suck!");
        }
    }
}

//Be careful with indentation for clarity sake
