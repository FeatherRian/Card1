using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    public List<Card> deck = new List<Card>();

    public int x;
    public int deckSize;
    public int nowDeckSize;
    public Card container;

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject CardBack;
    public GameObject DeckData;

    public GameObject CardToHand;

    public GameObject[] Clones;

    public GameObject Hand;
    
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 40;
        nowDeckSize = deckSize;
        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 5);
            deck.Add(CardDataBase.cardList[x]);
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {

        if(nowDeckSize<(deckSize/4*3))
        {
            cardInDeck1.SetActive(false);
        }
        else
        {
            cardInDeck1.SetActive(true);
        }
        if (nowDeckSize < (deckSize/2))
        {
            cardInDeck2.SetActive(false);
        }
        else
        {
            cardInDeck2.SetActive(true);
        }
        if (nowDeckSize < (deckSize/4))
        {
            cardInDeck3.SetActive(false);
        }
        else
        {
            cardInDeck3.SetActive(true);
        }
        if (nowDeckSize < 1)
        {
            cardInDeck4.SetActive(false);
        }
        else
        {
            cardInDeck4.SetActive(true);
        }
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        Clones = GameObject.FindGameObjectsWithTag("Clone");

        foreach (GameObject Clone in Clones)
        {
            Destroy(Clone);
        }
    }

    IEnumerator StartGame()
    {
       for(int i=0;i<=3;i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }
    public void Shuffle()
    {
        
        for (int i = 0; i < deckSize; i++)
        {
            container = deck[i];
            int randomVariable = Random.Range(i, deckSize);
            deck[i] = deck[randomVariable];
            deck[randomVariable] = container;
        }

        Instantiate(CardBack, transform.position, transform.rotation);
        StartCoroutine(Example());

    }
}
