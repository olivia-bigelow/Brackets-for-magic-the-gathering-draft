// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

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

//intialize random
Random rand = new();

//rearrange
for(int i = 0; i < 1000; i++)
{
    //get a temp random
    int playerToMove = rand.Next(8);
    while(i%8 == playerToMove)
    {
        //if the 2 values are the same, change it until theyre not
        playerToMove = rand.Next(8);
    }

    string p1 = players[playerToMove];
    players[playerToMove] = players[i%8];
    players[i%8] = p1;
}

//once the list is rearranged, display the brakect
for (int i = 0; i < players.Count; i++)
    Console.WriteLine((i+1) + ": " + players[i]);
