using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeDecrease : MonoBehaviour {
    public void DownHealth()
    {
        int money = PlayerPrefs.GetInt("Money");
        int moneyHP = PlayerPrefs.GetInt("MoneyHP");
        int upHealthValue = PlayerPrefs.GetInt("UpHealthValue");

        if (moneyHP > 100)
        {
            moneyHP /= 2;
            money += moneyHP;
            upHealthValue--;
            PlayerPrefs.SetInt("MoneyHP", moneyHP);
            PlayerPrefs.SetInt("UpHealthValue", upHealthValue);
            PlayerPrefs.SetInt("HP", 10 * upHealthValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void DownMove()
    {
        int money = PlayerPrefs.GetInt("Money");
        int moneyMove = PlayerPrefs.GetInt("MoneyMove");
        int upMoveValue = PlayerPrefs.GetInt("UpMoveValue");

        if (moneyMove > 100)
        {
            moneyMove /= 2;
            money += moneyMove;
            upMoveValue--;
            PlayerPrefs.SetInt("MoneyMove", moneyMove);
            PlayerPrefs.SetInt("UpMoveValue", upMoveValue);
            PlayerPrefs.SetFloat("Move", 0.1f * upMoveValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void DownFire()
    {
        int money = PlayerPrefs.GetInt("Money");
        int upFireValue = PlayerPrefs.GetInt("UpFireValue");
        int moneyFire = PlayerPrefs.GetInt("MoneyFire");
        if (moneyFire > 100)
        {
            moneyFire /= 2;
            money += moneyFire;
            upFireValue--;
            PlayerPrefs.SetInt("MoneyFire", moneyFire);
            PlayerPrefs.SetInt("UpFireValue", upFireValue);
            PlayerPrefs.SetFloat("Fire", 0.02f * upFireValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void DownEarn()
    {
        int money = PlayerPrefs.GetInt("Money");
        int upEarnValue = PlayerPrefs.GetInt("UpEarnValue");
        int moneyEarn = PlayerPrefs.GetInt("MoneyEarn"); ;
        if (moneyEarn > 100)
        {
            moneyEarn /= 2;
            money += moneyEarn;
            upEarnValue--;
            PlayerPrefs.SetInt("MoneyEarn", moneyEarn);
            PlayerPrefs.SetInt("UpEarnValue", upEarnValue);
            PlayerPrefs.SetInt("Earn", upEarnValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
}
