using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] cardSuits = new string[52];
            cardSuits[0] = "10-baptize";
            cardSuits[1] = "9-baptize";
            cardSuits[2] = "8-baptize";
            cardSuits[3] = "7-baptize";
            cardSuits[4] = "6-baptize";
            cardSuits[5] = "5-baptize";
            cardSuits[6] = "4-baptize";
            cardSuits[7] = "3-baptize";
            cardSuits[8] = "2-baptize";
            cardSuits[9] = "A-baptize";
            cardSuits[10] = "K-baptize";
            cardSuits[11] = "Q-baptize";
            cardSuits[12] = "J-baptize";
            cardSuits[13] = "10-diamonds";
            cardSuits[14] = "9-diamonds";
            cardSuits[15] = "8-diamonds";
            cardSuits[16] = "7-diamonds";
            cardSuits[17] = "6-diamonds";
            cardSuits[18] = "5-diamonds";
            cardSuits[19] = "4-diamonds";
            cardSuits[20] = "3-diamonds";
            cardSuits[21] = "2-diamonds";
            cardSuits[22] = "A-diamonds";
            cardSuits[23] = "K-diamonds";
            cardSuits[24] = "Q-diamonds";
            cardSuits[25] = "J-diamonds";
            cardSuits[26] = "10-worms";
            cardSuits[27] = "9-worms";
            cardSuits[28] = "8-worms";
            cardSuits[29] = "7-worms";
            cardSuits[30] = "6-worms";
            cardSuits[31] = "5-worms";
            cardSuits[32] = "4-worms";
            cardSuits[33] = "3-worms";
            cardSuits[34] = "2-worms";
            cardSuits[35] = "A-worms";
            cardSuits[36] = "K-worms";
            cardSuits[37] = "Q-worms";
            cardSuits[38] = "J-worms";
            cardSuits[39] = "10-peaks";
            cardSuits[40] = "9-peaks";
            cardSuits[41] = "8-peaks";
            cardSuits[42] = "7-peaks";
            cardSuits[43] = "6-peaks";
            cardSuits[44] = "5-peaks";
            cardSuits[45] = "4-peaks";
            cardSuits[46] = "3-peaks";
            cardSuits[47] = "2-peaks";
            cardSuits[48] = "A-peaks";
            cardSuits[49] = "K-peaks";
            cardSuits[50] = "Q-peaks";
            cardSuits[51] = "J-peaks";

            int[] cardIndex = new int[52];
            cardIndex[0] = 0;
            cardIndex[1] = 1;
            cardIndex[2] = 2;
            cardIndex[3] = 3;
            cardIndex[4] = 4;
            cardIndex[5] = 5;
            cardIndex[6] = 6;
            cardIndex[7] = 7;
            cardIndex[8] = 8;
            cardIndex[9] = 9;
            cardIndex[10] = 10;
            cardIndex[11] = 11;
            cardIndex[12] = 12;
            cardIndex[13] = 13;
            cardIndex[14] = 14;
            cardIndex[15] = 15;
            cardIndex[16] = 16;
            cardIndex[17] = 17;
            cardIndex[18] = 18;
            cardIndex[19] = 19;
            cardIndex[20] = 20;
            cardIndex[21] = 21;
            cardIndex[22] = 22;
            cardIndex[23] = 23;
            cardIndex[24] = 24;
            cardIndex[25] = 25;
            cardIndex[26] = 26;
            cardIndex[27] = 27;
            cardIndex[28] = 28;
            cardIndex[29] = 29;
            cardIndex[30] = 30;
            cardIndex[31] = 31;
            cardIndex[32] = 32;
            cardIndex[33] = 33;
            cardIndex[34] = 34;
            cardIndex[35] = 35;
            cardIndex[36] = 36;
            cardIndex[37] = 37;
            cardIndex[38] = 38;
            cardIndex[39] = 39;
            cardIndex[40] = 40;
            cardIndex[41] = 41;
            cardIndex[42] = 42;
            cardIndex[43] = 43;
            cardIndex[44] = 44;
            cardIndex[45] = 45;
            cardIndex[46] = 46;
            cardIndex[47] = 47;
            cardIndex[48] = 48;
            cardIndex[49] = 49;
            cardIndex[50] = 50;
            cardIndex[51] = 51;


            RandomBubble(cardIndex);
            DealCards(cardIndex, cardSuits);
            SortingCard(cardIndex, cardSuits);
            Console.ReadKey();

        }

        private static void SortingCard(int[] cardIndex, String[] cardSuits)
        {
            
            int start = 0;
            int n = 2;
            for (int t = 0; t <= n; t++)
            {
                int startSortIndex = start;
                int endtSortIndex = start + 5;
                for (int i = startSortIndex; i < endtSortIndex; i++)
                {
                    for (int j = i + 1; j < endtSortIndex; j++)
                    {
                        if (cardIndex[i] > cardIndex[j])
                        {
                            var temp1 = cardIndex[i];
                            cardIndex[i] = cardIndex[j];
                            cardIndex[j] = temp1;
                        }
                    }
                }
                Console.WriteLine($"Игрок номер {t}");
                for (var k = start; k < start + 5; k++)
                {

                    Console.WriteLine(cardIndex[k]);
                    Console.WriteLine(cardSuits[cardIndex[k]]);

                }
                start = start + 5;
            }


        }

        public static void DealCards(int[] cardIndex, String[] cardSuits)
        {
            int start = 0;
            int k = 0;

            for (k = start; k < start + 5; k++)
            {

                Console.WriteLine(cardIndex[k]);
                Console.WriteLine(cardSuits[cardIndex[k]]);
            }
            start += 5;
            Console.WriteLine(cardSuits[cardIndex[k]]);
            Console.WriteLine("-----------");

        }

        public static int[] RandomBubble(int[] cardIndex)
        {
            var random = new Random(); 

            int temp;
            for (int i = 0; i < cardIndex.Length; i++)
            {
                for (int j = i + 1; j < cardIndex.Length; j++)
                {
                    if (random.Next(19) > 5)
                    {
                        temp = cardIndex[i];
                        cardIndex[i] = cardIndex[j];
                        cardIndex[j] = temp;
                    }
                }
            }
            return cardIndex;

        }
    }
}
