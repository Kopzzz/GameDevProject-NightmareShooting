using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeIncrease : MonoBehaviour {
    public void UpHealth() {
        int money = PlayerPrefs.GetInt("Money");
        int moneyHP = PlayerPrefs.GetInt("MoneyHP");
        int upHealthValue = PlayerPrefs.GetInt("UpHealthValue");

        if (money >= moneyHP)
        {
            money -= moneyHP;
            moneyHP *= 2;
            upHealthValue++;
            PlayerPrefs.SetInt("MoneyHP", moneyHP);
            PlayerPrefs.SetInt("UpHealthValue", upHealthValue);
            PlayerPrefs.SetInt("HP", 10 * upHealthValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void UpMove()
    {
        int money = PlayerPrefs.GetInt("Money");
        int moneyMove = PlayerPrefs.GetInt("MoneyMove");
        int upMoveValue = PlayerPrefs.GetInt("UpMoveValue");

        if(money >= moneyMove)
        {
            money -= moneyMove;
            moneyMove *= 2;
            upMoveValue++;
            PlayerPrefs.SetInt("MoneyMove", moneyMove);
            PlayerPrefs.SetInt("UpMoveValue", upMoveValue);
            PlayerPrefs.SetFloat("Move", 0.1f * upMoveValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void UpFire()
    {
        int money = PlayerPrefs.GetInt("Money");
        int upFireValue = PlayerPrefs.GetInt("UpFireValue");
        int moneyFire = PlayerPrefs.GetInt("MoneyFire");
        if(money >= moneyFire)
        {
            money -= moneyFire;
            moneyFire *= 2;
            upFireValue++;
            PlayerPrefs.SetInt("MoneyFire", moneyFire);
            PlayerPrefs.SetInt("UpFireValue", upFireValue);
            PlayerPrefs.SetFloat("Fire", 0.01f * upFireValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
    public void UpEarn()
    {
        int money = PlayerPrefs.GetInt("Money");
        int upEarnValue = PlayerPrefs.GetInt("UpEarnValue");
        int moneyEarn = PlayerPrefs.GetInt("MoneyEarn");;
        if(money >= moneyEarn)
        {
            money -= moneyEarn;
            moneyEarn *= 2;
            upEarnValue++;
            PlayerPrefs.SetInt("MoneyEarn", moneyEarn);
            PlayerPrefs.SetInt("UpEarnValue", upEarnValue);
            PlayerPrefs.SetInt("Earn", upEarnValue);
        }
        PlayerPrefs.SetInt("Money", money);
    }
}
    

