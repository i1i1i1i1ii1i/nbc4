using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeTxt;
    public GameObject endTxt;
    float time = 0.0f;

    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");

        if (time >= 30.0f)
        {
            endTxt.SetActive(true);
            Time.timeScale=0.0f;
        } // 조건문을 이용하여 30초가 되었을 때 endTxt가 나오고 시간이 정지함. 4주차 강의 숙제
    }

    public static GameManager Instance;
    public Card firstCard;
    public Card secondCard;
    public int cardCount = 0;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void isMatched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            firstCard.DestoryCard();
            secondCard.DestoryCard();
            cardCount -= 2;

            if (cardCount == 0)
            {
                endTxt.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
        else
        {
            firstCard.CloseCard();
            secondCard.CloseCard();
        }
        

        firstCard = null;
        secondCard = null;
    }
}
