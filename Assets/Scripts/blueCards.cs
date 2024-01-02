using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blueCards : MonoBehaviour
{
    cardManager cardMng;
    public GameObject lookCard;
    Image viewCard;
    bool inScreen;
    public static int infantCount = 0, arcCount = 0, cavalCount = 0;
    public int cardPower;

    void Start()
    {
        cardMng = GameObject.Find("CardManager").GetComponent<cardManager>();
        viewCard = lookCard.GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inScreen)
        {
            inScreen = false;
            if (gameObject.CompareTag("infantry") && infantCount < cardMng.blueInfantry.Length)
                placeInfant();
            else if (gameObject.CompareTag("archer") && arcCount < cardMng.blueArcher.Length)
                placeArc();
            else if (gameObject.CompareTag("cavalry") && cavalCount < cardMng.blueCavalry.Length)
                placeCaval();
            else if (gameObject.CompareTag("areaCard"))
                placeAreaCard();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && inScreen)
        {
            closeView();
        }
    }

    void closeView()
    {
        inScreen = false;
        lookCard.SetActive(false);
        GetComponent<Image>().enabled = true;
    }

    public void OnButtonClick()
    {
        Debug.Log("on button click");
        viewCard.sprite = gameObject.GetComponent<Image>().sprite;
        lookCard.SetActive(true);
        GetComponent<Image>().enabled = false;
        inScreen = true;
    }

    void placeInfant()
    {
        cardMng.blueInfantry[infantCount].SetActive(true);
        cardMng.blueInfantry[infantCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        infantCount++;
        lookCard.SetActive(false);
    }

    void placeArc()
    {
        cardMng.blueArcher[arcCount].SetActive(true);
        cardMng.blueArcher[arcCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        arcCount++;
        lookCard.SetActive(false);
    }

    void placeCaval()
    {
        cardMng.blueCavalry[cavalCount].SetActive(true);
        cardMng.blueCavalry[cavalCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        cavalCount++;
        lookCard.SetActive(false);
    }

    void placeAreaCard()
    {
        if (gameObject.name == cardMng.allCards[15].name)
        {
            lookCard.SetActive(false);
        }
        else if (gameObject.name == cardMng.allCards[16].name)
        {
            lookCard.SetActive(false);
        }
        else if (cardManager.areaCount < 3)
        {
            Debug.Log(cardManager.areaCount);
            cardMng.areaCards[cardManager.areaCount].SetActive(true);
            cardMng.areaCards[cardManager.areaCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
            if (cardManager.areaCount != 2) cardManager.areaCount++;
            else cardManager.areaCount += 2;
            lookCard.SetActive(false);
        }
        else
        {
            Debug.Log("alan dolu");
            closeView();
        }
    }

}
