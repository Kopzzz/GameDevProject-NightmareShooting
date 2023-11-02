using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);


    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    PlayerShooting playerShooting;
    bool isDead;
    bool damaged;

    ScoreManager scoreManager;

    void Awake ()
    {
        int upHealth = PlayerPrefs.GetInt("HP");
        scoreManager = GetComponent <ScoreManager>();

        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();

        startingHealth += upHealth;
        currentHealth = startingHealth;
        healthSlider.maxValue = startingHealth;
        healthSlider.value = currentHealth;
    }



    void Update ()
    {
        playerShooting = GetComponentInChildren<PlayerShooting>();
        if (damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage (int amount,int obj)
    {
        if(obj == 1)
        {
            damaged = true;
            playerAudio.Play();
        }
        if(obj == 2)
        {

        }
        currentHealth -= amount;
        if (currentHealth > startingHealth) currentHealth = startingHealth;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0 && !isDead)
        {
           Death ();
        }
    }


    void Death ()
    {
        isDead = true;
        playerShooting.DisableEffects ();

        anim.SetTrigger ("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play ();

        playerMovement.enabled = false;
        playerShooting.enabled = false;

        int money = PlayerPrefs.GetInt("Money");
        int plusMoney = PlayerPrefs.GetInt("PlusMoney");
        money += plusMoney;
        PlayerPrefs.SetInt("Money", money);
    }


}
