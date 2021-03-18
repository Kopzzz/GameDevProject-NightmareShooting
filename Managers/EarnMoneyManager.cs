using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnMoneyManager : MonoBehaviour {

    Text text;
    public int earn;
    int upEarn;
    void Awake()
    {
        text = GetComponent<Text>();
        earn = 0;
        upEarn = PlayerPrefs.GetInt("Earn");
    }


    void Update()
    {
        int earn = ScoreManager.score/10;
        earn *= (upEarn + 10);
        earn /= 10;
        text.text = "Earn Money : " + earn;
        PlayerPrefs.SetInt("PlusMoney", earn);
    }
}
