using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleAndCards = Console.ReadLine();

            char[] separators = new char[] { ' ', ':', ',' };
            Dictionary<string, int> personData = new Dictionary<string, int>();
            Dictionary<string, string> dictPersonData = new Dictionary<string, string>();


            while (peopleAndCards != "JOKER")
            {
                List<string> peopleAndCardsRemovedSymbols = peopleAndCards.Split(':').ToList();
                string name = peopleAndCardsRemovedSymbols[0];
                peopleAndCardsRemovedSymbols.RemoveAt(0);
                string temp = string.Join("", peopleAndCardsRemovedSymbols);
                List<string> tempList = temp.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();


                string tempJoin = string.Join(" ", tempList);
                if (dictPersonData.ContainsKey(name))
                {
                    dictPersonData[name] += " " + tempJoin;
                }
                else
                {
                    dictPersonData.Add(name, tempJoin);
                }
                
                peopleAndCards = Console.ReadLine();
            }
            
            
            foreach (var item in dictPersonData)
            {
                List<string> cards = item.Value.Split(separators, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                int sumCards = 0;
                for (int i = 0; i < cards.Count; i++)
                {
                    sumCards += CalculateCards(cards[i]);
                }
                Console.WriteLine($"{item.Key}: {sumCards}");
            }
        }

        static int CalculateCards(string cards)
        {
            int sum = 0;
            int cardPower = 0;
            int cardType = 0;
            int saveDigitForTen = 0;
            foreach (var item in cards)
            {
                switch (item)
                {
                    case '2': cardPower = 2; break;
                    case '3': cardPower = 3; break;
                    case '4': cardPower = 4; break;
                    case '5': cardPower = 5; break;
                    case '6': cardPower = 6; break;
                    case '7': cardPower = 7; break;
                    case '8': cardPower = 8; break;
                    case '9': cardPower = 9; break;
                    case 'J': cardPower = 11; break;
                    case 'Q': cardPower = 12; break;
                    case 'K': cardPower = 13; break;
                    case 'A': cardPower = 14; break;
                    case 'S': cardType = 4; break;
                    case 'H': cardType = 3; break;
                    case 'D': cardType = 2; break;
                    case 'C': cardType = 1; break;
                    default:
                        break;
                }
                if (item == '1')
                {
                    saveDigitForTen = 1;
                }
                if (saveDigitForTen == 1 && item == '0')
                {
                    cardPower = 10;
                }
                sum = cardPower * cardType;
            }
            return sum;
        }
    }
}

