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
    public List<int> Deck1;
    public List<int> Deck2;

    private void Awake()
    {
        Cards = Resources.LoadAll<Sprite>("Sprites");
        
    }
    void Start()
    {
        
        btn1.image.sprite = Card;
        btn2.image.sprite = Card;
        numbers.Add(0);
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Add(8);
        numbers.Add(9);
        numbers.Add(10);
        numbers.Add(11);
        numbers.Add(12);
        numbers.Add(13);
        numbers.Add(14);
        numbers.Add(15);
        numbers.Add(16);
        numbers.Add(17);
        numbers.Add(18);
        numbers.Add(19);
        numbers.Add(20);
        numbers.Add(21);
        numbers.Add(22);
        numbers.Add(23);
        numbers.Add(24);
        numbers.Add(25);
        numbers.Add(26);
        numbers.Add(27);
        numbers.Add(28);
        numbers.Add(29);
        numbers.Add(30);
        numbers.Add(31);
        numbers.Add(32);
        numbers.Add(33);
        numbers.Add(34);
        numbers.Add(35);
        numbers.Add(36);
        numbers.Add(37);
        numbers.Add(38);
        numbers.Add(39);

        shuffle();

    }

    void shuffle()
    {
        for (int i = 0; i < 40; i++)
        {
            int b = Random.Range(0,numbers.Count);
            if (i%2 == 0)
            {
                Deck1.Add(numbers[b]);
            }
            else
            {
                Deck2.Add(numbers[b]);
            }
            
            numbers.Remove(numbers[b]);
        }
        print(Deck1);
    }
}
