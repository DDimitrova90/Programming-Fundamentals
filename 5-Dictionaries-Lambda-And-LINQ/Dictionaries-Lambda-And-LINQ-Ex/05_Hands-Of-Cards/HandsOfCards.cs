using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split(':');
        string name = sequence[0];
        Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

        while (!name.Equals("JOKER"))
        {
            List<string> cards = new List<string>();
            cards = sequence[1].Split(new char[] { ',', ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();

            if (players.ContainsKey(name))
            {
                players[name].AddRange(cards);
                players[name] = players[name].Distinct().ToList();
            }
            else
            {
                players[name] = cards.Distinct().ToList();
            }

            sequence = Console.ReadLine().Split(':');
            name = sequence[0];
        }

        foreach (KeyValuePair<string, List<string>> player in players)
        {
            int handValue = 0;

            for (int i = 0; i < player.Value.Count; i++)
            {
                string cardType = player.Value[i].Substring(player.Value[i].Length - 1);
                string power = player.Value[i].Substring(0, player.Value[i].Length - 1);
                int typeValue = 0;
                int cardPower = 0;

                switch (cardType)
                {
                    case "S":
                        typeValue = 4;
                        break;
                    case "H":
                        typeValue = 3;
                        break;
                    case "D":
                        typeValue = 2;
                        break;
                    case "C":
                        typeValue = 1;
                        break;
                }

                switch (power)
                {
                    case "J":
                        cardPower = 11;
                        break;
                    case "Q":
                        cardPower = 12;
                        break;
                    case "K":
                        cardPower = 13;
                        break;
                    case "A":
                        cardPower = 14;
                        break;
                    default:
                        cardPower = int.Parse(power);
                        break;
                }

                handValue += typeValue * cardPower;
            }

            Console.WriteLine($"{player.Key}: {handValue}");
        }        
    }
}

