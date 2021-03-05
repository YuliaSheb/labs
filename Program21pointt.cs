using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Nominal
    {
        Jack = 2,
        Dame = 3,
        King = 4,
        Ace = 11,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10
    }
    public enum Suit
    {
        Spades = 1,
        Clubs = 2,
        Diamonds = 3,
        Hearts = 4
    }
    public class Card
    {
        private Nominal numb;
        private Suit suit;
        public Card(Nominal n, Suit s)
        {
            numb = n;
            suit = s;
        }

        public void Draw()
        {
            Console.WriteLine(numb.ToString() + " " + suit.ToString());
            //return numb.ToString() + " " + suit.ToString();

        }
        public int GetValue()
        {
            return (int)numb;
        }
    }

    public class Deck
    {
        private Stack<Card> cards = new Stack<Card>();
        public void FillandShuffleDeck()
        {
            foreach (var n in Enum.GetValues(typeof(Nominal)))
            {
                foreach (var s in Enum.GetValues(typeof(Suit)))
                {
                    cards.Push(new Card((Nominal)n, (Suit)s));
                }
            }
            var rand = new Random();
            var cardsL = cards.ToList<Card>();
            for (var j = cardsL.Count - 1; j > 0; j--)
            {
                var i = rand.Next(j);
                var t = cardsL[i];
                cardsL[i] = cardsL[j];
                cardsL[j] = t;
            }
            cards = new Stack<Card>(cardsL);
        }
        public void Draw()
        {
            foreach (var cart in cards)
            {
                cart.Draw();
            }
        }
        public Card GetCard()
        {
            return cards.Pop();
        }
    }
    public class Game
    {
        private Deck desk;
        private List<Card> carta;
        private int Calculate()
        {
            int sum = 0;
            foreach (var c in carta)
            {
                sum += c.GetValue();
            }
            return sum;
        }
        public Game()
        {

        }
        public void Play()
        {
            desk = new Deck();
            carta = new List<Card>();
            desk.FillandShuffleDeck();
            bool last = true;
            while (last)
            {
                Card card = desk.GetCard();
                card.Draw();
                carta.Add(card);
                int sum = Calculate();
                Console.WriteLine("You point:" + " " + sum);
                if (sum == 21)
                {
                    Console.WriteLine("You won!");
                    return;
                }
                else if (sum > 21)
                {
                    Console.WriteLine("You lost");
                    return;
                }
                else
                {
                    Console.WriteLine("Press 1 to get the card. Press 2 to finish.");
                    string option = Console.ReadLine();
                    if (option == "2")
                    {
                        Console.WriteLine("You point:" + " " + sum);
                        last = false;
                    }
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.Play();
                Console.WriteLine("Do you want one more card (Y/n)?");
                if (Console.ReadLine() != "Y") 
                {
                    break;
                }
            }
        }

    }
}
    




