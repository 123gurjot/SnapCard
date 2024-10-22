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
    public List<int> numbers;
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
        for( int i =0; i < 52; i++)
        {
            numbers.Add(i);
        }

        shuffle();

    }

    void shuffle()
    {
        for (int i = 0; i < 52; i++)
        {
            int b = Random.Range(0,numbers.Count);
            if (i%2 == 0)
            {
                Deck1.Add(Cards[numbers[b]]);
            }
            else
            {
                Deck2.Add(Cards[numbers[b]]);
            }
            
            numbers.Remove(numbers[b]);
        }
        print(Deck1);
    }

    private void Update()
    {
        while(Deck1.Count != 0 || Deck2.Count != 0)
        {
            int i = 0;
            if (Deck1[1].name == "")
            {

            }
        }
    }
}
