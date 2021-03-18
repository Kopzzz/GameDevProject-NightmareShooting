using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {
    void Awake()
    {
        if (PlayerPrefs.HasKey("Money") == false)
        {
            PlayerPrefs.SetInt("Money", 0);
            PlayerPrefs.SetInt("MoneyHP", 100);
            PlayerPrefs.SetInt("MoneyMove", 100);
            PlayerPrefs.SetInt("MoneyFire", 100);
            PlayerPrefs.SetInt("MoneyEarn", 100);
            PlayerPrefs.SetInt("UpHealthValue", 0);
            PlayerPrefs.SetInt("UpMoveValue", 0);
            PlayerPrefs.SetInt("UpFireValue", 0);
            PlayerPrefs.SetInt("UpEarnValue", 0);
            PlayerPrefs.SetInt("HP", 0);
            PlayerPrefs.SetFloat("Move", 0);
            PlayerPrefs.SetFloat("Fire", 0);
            PlayerPrefs.SetInt("Earn", 0);
        }
    }
    void Update()
    {
        int money = PlayerPrefs.GetInt("Money");
        if (Input.GetButton("Vertical"))
        {
            money += 100;
            PlayerPrefs.SetInt("Money", money);
        }
    }
}
