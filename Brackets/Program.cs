namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add players
            List<string> players = new();
            players.Add("Liv");
            players.Add("Tasha");
            players.Add("Matt");
            players.Add("Jackson");
            players.Add("David");
            players.Add("Adrian");
            players.Add("Lorens");
            players.Add("placeholder");

            //rearange
            printBracket(players);
        }

        public static void printBracket<T>(List<T> list) where T : notnull
        {
            //intialize random
            Random rand = new();

            //rearrange
            for (int i = 0; i < 1000; i++)
            {
                //get a temp random
                int playerToMove = rand.Next(list.Count);
                while (i % list.Count == playerToMove)
                {
                    //if the 2 values are the same, change it until theyre not
                    playerToMove = rand.Next(list.Count);
                }

                T p1 = list[playerToMove];
                list[playerToMove] = list[i % list.Count];
                list [i % list.Count] = p1;
            }

            //once the list is rearranged, display the brakect
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine((i + 1) + ": " + list[i]);
        }
    }
}