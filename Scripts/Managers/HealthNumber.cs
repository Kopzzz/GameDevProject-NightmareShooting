using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthNumber : MonoBehaviour {
    PlayerHealth playerHealth;
    Text text;
    GameObject player;

    void Awake()
    {
        text = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        int health = playerHealth.startingHealth;
    }


    void Update()
    {
        int health = playerHealth.currentHealth;
        if (health <= 0) health = 0;
        text.text = "" + health;
    }
}
