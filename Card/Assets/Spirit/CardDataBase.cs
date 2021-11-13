using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Demo", "This is a demo","None",0));
        cardList.Add(new Card(1, "HNO3", "氧化", "酸", 0));
        cardList.Add(new Card(2, "H2SO4", "氧化", "酸", 0));
        cardList.Add(new Card(3, "NaOH", "腐蚀", "碱", 0));
        cardList.Add(new Card(4, "Na2CO3", "电解", "盐", 0));
        cardList.Add(new Card(5, "CaCO3", "电解", "盐", 0));
    }
}
