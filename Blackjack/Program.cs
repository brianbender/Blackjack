using System;

namespace Blackjack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var money = 500;
            Console.WriteLine("Welcome to blackjack. You have $500. Each hand costs $25. You win at $1000.");

            while (money > 0)
            {
                var yourHand = GetNewHand();

                Console.WriteLine($"Your cards are {GetCardName(yourHand.Item1)} and {GetCardName(yourHand.Item2)}");

                var dealerHand = GetNewHand();
                Console.WriteLine($"The dealer is showing a {GetCardName(dealerHand.Item1)}. Do you (h)it or (s)tay?");

                var input = Console.ReadKey().KeyChar.ToString();
                while (input != "h" && input != "s")
                {
                    Console.WriteLine("Do you (h)it or (s)tay?");
                    input = Console.ReadKey().KeyChar.ToString();
                }
                Console.WriteLine();
                if (input == "s")
                {
                    Console.WriteLine(Environment.NewLine +
                                      $"The dealer flips their other card over. It's a {GetCardName(dealerHand.Item2)}.");
                }
                var newCard = 0;
                if (input == "h")
                {
                    var random = new Random();
                    newCard = random.Next(1, 14);
                    Console.WriteLine($"The dealer slides another card to you. It's a {GetCardName(newCard)}.");
                }

                var yourCards = GetCardValue(yourHand.Item1) + GetCardValue(yourHand.Item2) + GetCardValue(newCard);
                var dealersCards = GetCardValue(dealerHand.Item1) + GetCardValue(dealerHand.Item2);
                if (yourCards <= dealersCards || yourCards > 21)
                {
                    money -= 25;
                    var loseMessage = yourCards > 21 ? "You busted!" : "You lost!";
                    Console.WriteLine($"You had {yourCards} and dealer had {dealersCards}. {loseMessage} You now have ${money} (-$25)");
                }
                else
                {
                    money += 25;
                    Console.WriteLine($"You had {yourCards} and dealer had {dealersCards}. You won! You now have ${money} (+$25).");
                }
                if (money >= 1000)
                {
                    Console.WriteLine("You win!");
                    Console.ReadKey();
                    return;
                }
            }


            Console.WriteLine("You lose.");
            Console.ReadKey();
        }

        private static int GetCardValue(int card)
        {
            if (card > 10)
                return 10;
            return card;
        }

        private static string GetCardName(int card)
        {
            if (card == 1)
                return "Ace";
            if (card == 11)
                return "Jack";
            if (card == 12)
                return "Queen";
            if (card == 13)
                return "King";
            return card.ToString();
        }

        private static Tuple<int, int> GetNewHand()
        {
            var random = new Random();

            var num1 = random.Next(1, 14);
            var num2 = random.Next(1, 14);
            return new Tuple<int, int>(num1, num2);
        }
    }
}