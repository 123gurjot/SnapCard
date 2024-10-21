using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Sprite Card;
    public int CardCount;
    public Sprite[] Cards;
    public Button btn1;
    public Button btn2;
    public List<Sprite> Deck1;
    public List<Sprite> Deck2;

    private void Awake()
    {
        Cards = Resources.LoadAll<Sprite>("Sprites");
    }
    void Start()
    {
        btn1.image.sprite = Card;
        btn2.image.sprite = Card;
        shuffle();
    }

    void shuffle()
    {
        for (int i = 0; i < CardCount; i++)
        {
            if (i == 0 || i == 2)
            {
                Deck1.Add(Cards[i]);
            }
            if (i == 1 || i == 3)
            {
                Deck2.Add(Cards[i]);
            }
        }
    }
}
