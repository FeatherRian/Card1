using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TheCardBack : MonoBehaviour
{
    public Card theCard;
    public int theId;
    public int id;
    public string cardName;
    public string cardDescription;
    public string cardCategory;
    public int cardCost;
    public Text nameText;
    public Text descriptionText;
    public Text categoryText;
    public Text costText;

    public bool theCardBack = false;
    // Start is called before the first frame update
    void Start()
    {
        theCard = CardDataBase.cardList[theId];
    }

    // Update is called once per frame
    void Update()
    {
        id = theCard.id;
        cardName = theCard.cardName;
        cardDescription = theCard.cardDescription;
        cardCategory = theCard.category;
        cardCost = theCard.cost;


        nameText.text = "" + cardName;
        descriptionText.text = "   " + cardDescription;
        categoryText.text = "" + cardCategory;
        costText.text = "" + cardCost;
    }
}
