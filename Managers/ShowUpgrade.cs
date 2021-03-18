using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUpgrade : MonoBehaviour {
    public int type;
    Text text;

    void Start () {
        text = GetComponent<Text>();
    }
	
	void Update () {
        if (type == 0)
        {
            int money = PlayerPrefs.GetInt("Money");
            text.text = "" + money;
        }
        if (type == 1)
        {
            int moneyHP = PlayerPrefs.GetInt("MoneyHP");
            text.text = "" + moneyHP;
        }
        if (type == 2)
        {
            int moneyMove = PlayerPrefs.GetInt("MoneyMove");
            text.text = "" + moneyMove;
        }
        if (type == 3)
        {
            int moneyFire = PlayerPrefs.GetInt("MoneyFire");
            text.text = "" + moneyFire;
        }
        if (type == 4)
        {
            int moneyEarn = PlayerPrefs.GetInt("MoneyEarn");
            text.text = "" + moneyEarn;
        }
        if (type == 5)
        {
            int upHealthValue = PlayerPrefs.GetInt("UpHealthValue");
            text.text = "" + upHealthValue;
        }
        if (type == 6)
        {
            int upMoveValue = PlayerPrefs.GetInt("UpMoveValue");
            text.text = "" + upMoveValue;
        }
        if (type == 7)
        {
            int upFireValue = PlayerPrefs.GetInt("UpFireValue");
            text.text = "" + upFireValue;
        }
        if (type == 8)
        {
            int upEarnValue = PlayerPrefs.GetInt("UpEarnValue");
            text.text = "" + upEarnValue;
        }

    }
}
