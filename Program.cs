using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new List<string>() { "Ace of Hearts", "Ace of Clubs", "Ace of Diamonds", "Ace of Spades", "2 of Hearts", "2 of Clubs", "2 of Diamonds", "2 of Spades", "3 of Hearts", "3 of Clubs", "3 of Diamonds", "3 of Spades", "4 of Hearts", "4 of Clubs", "4 of Diamonds", "4 of Spades", "5 of Hearts", "5 of Clubs", "5 of Diamonds", "5 of Spades", "6 of Hearts", "6 of Clubs", "6 of Diamonds", "6 of Spades", "7 of Hearts", "7 of Clubs", "7 of Diamonds", "7 of Spades", "8 of Hearts", "8 of Clubs", "8 of Diamonds", "8 of Spades", "9 of Hearts", "9 of Clubs", "9 of Diamonds", "9 of Spades", "10 of Hearts", "10 of Clubs", "10 of Diamonds", "10 of Spades", "Jack of Hearts", "Jack of Clubs", "Jack of Diamonds", "Jack of Spades", "Queen of Hearts", "Queen of Clubs", "Queen of Diamonds", "Queen of Spades", "King of Hearts", "King of Clubs", "King of Diamonds", "King of Spades" };

            // numberOfCards = length of our deck
            var numberOfCards = cards.Count;
            // Console.WriteLine($"{numberOfCards}");

            // for rightIndex from numberOfCards - 1 down to 1 do:
            //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")

            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);

                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftCard = the value from deck[leftIndex]
                var leftCard = cards[leftIndex];
                //     rightCard = the value from deck[rightIndex]
                var rightCard = cards[rightIndex];

                //     deck[rightIndex] = leftCard
                //     deck[leftIndex] = rightCard
                cards[rightIndex] = leftCard;
                cards[leftIndex] = rightCard;
            }

            // foreach (var card in cards)
            // {
            //     Console.WriteLine($"{card}");

            // }

            // for (var cardsIndex = 0; cardsIndex <= 0; cardsIndex++)
            // {
            //     var cardDealtOne = cards[0];
            //     var cardDealtTwo = cards[1];
            //     Console.WriteLine($"Cards dealt: {cardDealtOne} and {cardDealtTwo}");
            // }

            var cardDealtOne = cards[0];
            var cardDealtTwo = cards[1];
            Console.WriteLine($"Cards dealt: {cardDealtOne} and {cardDealtTwo}");

            Console.WriteLine($"------------------- Gavin's walkthrough -------------------");


            var cardSuits = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var newDeck = new List<string>();

            foreach (var suit in cardSuits)
            {
                // Console.WriteLine($"{suit}");
                foreach (var value in cardValues)
                {
                    // Console.WriteLine($"    {value}");

                    var newString = $"{value} of {suit}";
                    Console.WriteLine($"{newString}");

                    newDeck.Add(newString);
                }
            }
        }
    }
}
