using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    int handMaxSize = 5;
    public Card 
    public List<Card> Hand = new List<Card>();

    public void DrawCard () {
        Card card1 = new Card;
        card1.name = "Cameron";
        card1.desc = "A card named Cameron";
        Hand.Add(card1);
    }
}
