using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TheCard : MonoBehaviour
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

    public GameObject Hand;

    public int numberOfCardsInDeck;

    public GameObject TheDeck;

    void Start()
    {
        theCard = CardDataBase.cardList[theId];
        TheDeck = GameObject.Find("Deck");
        numberOfCardsInDeck = TheDeck.GetComponent<Deck>().nowDeckSize;


    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");
        if(this.transform.parent == Hand.transform.parent)
        {
            theCardBack = false;
        }
        id = theCard.id;
        cardName = theCard.cardName;
        cardDescription = theCard.cardDescription;
        cardCategory = theCard.category;
        cardCost = theCard.cost;


        nameText.text = "" + cardName;
        descriptionText.text = "   " + cardDescription;
        categoryText.text = "" + cardCategory;
        costText.text = ""+cardCost;

        if (this.tag == "Clone")
        {
            theCard = TheDeck.GetComponent<Deck>().deck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            TheDeck.GetComponent<Deck>().nowDeckSize -= 1;
            theCardBack = false;
            this.tag = "Untagged";
        }
    }

}
