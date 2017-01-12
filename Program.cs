using System;
// using Card;

namespace DeckofCards
{



    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.shuffle();

            Player player1 = new Player("Dave");
            Player player2 = new Player("Computer");
            player1.Deal(myDeck);
            player2.Deal(myDeck);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Are you Bold Enough to Play? - Type Y to Play the Toledo Panic Button");
            string InputLine = Console.ReadLine();
            while (InputLine == "Y" || InputLine == "y" ) {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Allie has " + player1.hand[0]);
            Console.WriteLine("");        
            Console.WriteLine("Seth has " + player2.hand[0]);
            Console.WriteLine("");
            Console.WriteLine("");
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

                Console.WriteLine("");
                Console.WriteLine("Are you Bold Enough to Play? - Type Y to Play the Toledo Panic Button");
                InputLine = Console.ReadLine();
            }
            Console.WriteLine("You Suck!");
        }
    }
}
