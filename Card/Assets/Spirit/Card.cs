using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{

    public int id;
    public string cardName;
    public string cardDescription;
    public string category;
    public int cost;

    public Card()
    {

    }
    //          卡牌ID        卡名             卡牌描述        卡牌类型  卡牌消耗费用
    public Card(int Id,string CardName,string CardDescription,string Category,int Cost)
    {
        id = Id;
        cardName = CardName;
        cardDescription = CardDescription;
        category = Category;
        cost = Cost;
    }
}
