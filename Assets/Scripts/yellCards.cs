using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yellCards : MonoBehaviour
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
            if (gameObject.CompareTag("infantry") && infantCount < cardMng.yellowInfantry.Length)
                placeInfant();
            else if (gameObject.CompareTag("archer") && arcCount < cardMng.yellowArcher.Length)
                placeArc();
            else if (gameObject.CompareTag("cavalry") && cavalCount < cardMng.yellowCavalry.Length)
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
        cardMng.yellowInfantry[infantCount].SetActive(true);
        cardMng.yellowInfantry[infantCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        infantCount++;
        lookCard.SetActive(false);
    }

    void placeArc()
    {
        cardMng.yellowArcher[arcCount].SetActive(true);
        cardMng.yellowArcher[arcCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        arcCount++;
        lookCard.SetActive(false);
    }

    void placeCaval()
    {
        cardMng.yellowCavalry[cavalCount].SetActive(true);
        cardMng.yellowCavalry[cavalCount].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
        cavalCount++;
        lookCard.SetActive(false);
    }

    void placeAreaCard()
    {
        

        if (gameObject.name == cardMng.allCards[15].name)
        {
            lookCard.SetActive(false);
            Debug.Log("d¨¹z arazi kart");
        }
        else if (gameObject.name == cardMng.allCards[16].name)
        {
            lookCard.SetActive(false);
            Debug.Log("cellat kart");
        }
        else if (cardManager.areaCount < 3)
        {
            if (gameObject.name == "orman")
            {
                cardMng.areaCards[0].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
                cardMng.areaCards[0].name = gameObject.name;
            }
            else if (gameObject.name == "dag")
            {
                cardMng.areaCards[1].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
                cardMng.areaCards[1].name = gameObject.name;
            }
            else if (gameObject.name == "batak")
            {
                cardMng.areaCards[2].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
                cardMng.areaCards[2].name = gameObject.name;
            }
                cardMng.areaCards[cardManager.areaCount].SetActive(true);
                
                lookCard.SetActive(false);
        }
        else
        {
            Debug.Log("alan dolu");
            closeView();
        }
    }
}
