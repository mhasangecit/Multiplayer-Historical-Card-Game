using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cardManager : MonoBehaviour
{
    public GameObject[] allCards;
    public GameObject[] areaCards;
    public GameObject[] allYellowCards;
    public GameObject[] allBlueCards;

    public GameObject[] yellowInfantry;
    public GameObject[] yellowArcher;
    public GameObject[] yellowCavalry;

    public GameObject[] blueInfantry;
    public GameObject[] blueArcher;
    public GameObject[] blueCavalry;

    public GameObject lookCard, yellowHole, blueHole;

    public TextMeshProUGUI[] yellowPoints;
    public TextMeshProUGUI[] bluePoints;
    public TextMeshProUGUI yellowCardCount, yellowZulaCount;
    public TextMeshProUGUI blueCardCount, blueZulaCount;

    public int soldMinCount, soldMaxCount;

    static int yelcardsCount=0;
    static int bluecardsCount=0;
    public static int areaCount=0;

    void Start()
    {
        placeYellowDeck();
        placeBlueDeck();
    }
    
    void placeYellowDeck()
    {
        int soldierCount = Random.Range(soldMinCount, soldMaxCount);
        for (int i = 0; i < soldierCount; i++)
        {
            int randomSoldier = Random.Range(0, 6);
            allYellowCards[yelcardsCount].GetComponent<Image>().sprite = allCards[randomSoldier].GetComponent<Image>().sprite;
            allYellowCards[yelcardsCount].gameObject.tag = allCards[randomSoldier].gameObject.tag;
            yelcardsCount++;
        }
        for (int i = 0; i < (10 - soldierCount); i++)
        {
            int randomArea = Random.Range(12, 17);
            allYellowCards[yelcardsCount].GetComponent<Image>().sprite = allCards[randomArea].GetComponent<Image>().sprite;
            allYellowCards[yelcardsCount].gameObject.tag = allCards[randomArea].gameObject.tag;
            allYellowCards[yelcardsCount].gameObject.name = allCards[randomArea].gameObject.name;
            yelcardsCount++;
        }
    }

    void placeBlueDeck()
    {
        int soldierCount = Random.Range(soldMinCount, soldMaxCount);
        for (int i = 0; i < soldierCount; i++)
        {
            int randomSoldier = Random.Range(6, 12);
            allBlueCards[bluecardsCount].GetComponent<Image>().sprite = allCards[randomSoldier].GetComponent<Image>().sprite;
            allBlueCards[bluecardsCount].gameObject.tag = allCards[randomSoldier].gameObject.tag;
            bluecardsCount++;
        }
        for (int i = 0; i < (10-soldierCount); i++)
        {
            int randomArea = Random.Range(12, 17);
            allBlueCards[bluecardsCount].GetComponent<Image>().sprite = allCards[randomArea].GetComponent<Image>().sprite;
            allBlueCards[bluecardsCount].gameObject.tag = allCards[randomArea].gameObject.tag;
            allBlueCards[bluecardsCount].gameObject.name = allCards[randomArea].gameObject.name;
            bluecardsCount++;
        }
    }
}
