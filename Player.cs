using System;
using System.Collections.Generic;

namespace DeckofCards
{
    public class Player
    {
        public string name {get; set;}
        public List<Card> hand = new List<Card>();
        public Player(string n)
        {
            name = n;
        }
        // public void Draw(Deck deck) {
        //     hand.Add(deck.deal());
        // }
        public void Deal(Deck deck) {
            for (int i=0; i < 26; i++) {
            hand.Add(deck.draw());
            }
        }

        public Card Discard(int CardIdx)
        {
            if(hand[CardIdx] != null){
                Card toReturn = hand[CardIdx];
                hand.RemoveAt(CardIdx);
                return toReturn;
            }
            return null;
        }
    }
}