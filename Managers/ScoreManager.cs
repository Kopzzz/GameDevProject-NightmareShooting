using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text text;
    public int type;
    float timer;
    int printTime;

    public PlayerHealth playerHealth;


    void Awake ()
    {
        text = GetComponent <Text> ();
        score = 0;
    }


    void Update ()
    {
        if (playerHealth.currentHealth > 0)
        {
            timer += Time.deltaTime;
        }
        printTime = (int)timer;
        if (type == 1) text.text = "Score : " + score;
        else if (type == 2) text.text = "Survival Time : " + printTime;
    }

}
