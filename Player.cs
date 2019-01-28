using System;
using System.Collections;
using System.Collections.Generic;

public class Player
{
    int handMaxSize = 5;
    public List<Card> Hand = new List<Card>();

    public void DrawCard () {
        Card card1 = new Card();
        card1.name = "Cameron";
        card1.desc = "A card named Cameron";
        Hand.Add(card1);
        Console.Log(Hand);
    }

    DrawCard();
}
