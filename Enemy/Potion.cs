using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {
    PlayerMovement playerMovement;
    PlayerHealth playerHealth;
    PlayerShooting playerShooting;
    GameObject player;
    GameObject gun;
    public int type;

    private void Awake()
    {
        transform.Rotate(new Vector3(-40f , 0f, 0f));
        transform.position += Vector3.up;
        player = GameObject.FindGameObjectWithTag("Player");
        gun = GameObject.FindGameObjectWithTag("Gun");
        playerMovement = player.GetComponent<PlayerMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();
        playerShooting = gun.GetComponent<PlayerShooting>();
    }
    void FixedUpdate () {
        transform.Rotate(new Vector3(0f,30f,0f)*Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (type == 1)
            {
                playerMovement.Fast();
                Destroy(gameObject);
            }
            if (type == 2)
            {
                playerHealth.TakeDamage(-20,2);
                Destroy(gameObject);
            }
            if(type == 3)
            {
                playerShooting.Boost();
                Destroy(gameObject);
            }
        }

    }
}
