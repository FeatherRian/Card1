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
    //          ����ID        ����             ��������        ��������  �������ķ���
    public Card(int Id,string CardName,string CardDescription,string Category,int Cost)
    {
        id = Id;
        cardName = CardName;
        cardDescription = CardDescription;
        category = Category;
        cost = Cost;
    }
}
