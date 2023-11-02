using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    float timer = 0;

    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            timer += Time.deltaTime;
            anim.SetTrigger("GameOver");
            if (Input.GetMouseButtonDown(0) && timer >=2)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
