using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game : MonoBehaviour
{
    public Text scoreText;
    public Text moneyText;
    public GameObject delete;
    private int money;
    private int score;
    public GameObject ShopPan;
    public Text gameoverText;
    
    
    public void Update()
    {
        scoreText.text = score + "";
        moneyText.text = money + "$";
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("score", score);
    }
    public void ShopPan_ShowAndHIde()
    {
        ShopPan.SetActive(!ShopPan.activeSelf);
    }

    public void OnClick1()
    {
        if (money >= 20)
        {
            Destroy(delete);
            gameoverText.text = "Game over";
            money -= 20;
        }

    }
    
    public void OnClcick()
    {
        score++;
        scoreText.text = score + "";
        money++;
        moneyText.text = money + "$";

    }
     void Start()
    {
        money = PlayerPrefs.GetInt("money", money);
        score = PlayerPrefs.GetInt("score", score);
    }
}
