using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void RestartUpgrade()
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
        PlayerPrefs.SetInt("HP",0);
        PlayerPrefs.SetFloat("Move", 0);
        PlayerPrefs.SetFloat("Fire", 0);
        PlayerPrefs.SetInt("Earn", 0);
    }
}
