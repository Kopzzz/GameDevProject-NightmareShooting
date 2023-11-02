using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float damagePerShot;
    public float timeBetweenBullets;
    public float range = 100f;
    bool boost = false;

    float timer;
    float timeCount = 0;
    Ray shootRay = new Ray();
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunParticles;
    LineRenderer gunLine;
    AudioSource gunAudio;
    Light gunLight;
    float effectsDisplayTime = 0.2f;

    void Awake ()
    {
        shootableMask = LayerMask.GetMask ("Shootable");
        gunParticles = GetComponent<ParticleSystem> ();
        gunLine = GetComponent <LineRenderer> ();
        gunAudio = GetComponent<AudioSource> ();
        gunLight = GetComponent<Light> ();
        float upFire = PlayerPrefs.GetFloat("Fire");
        timeBetweenBullets /= (upFire+1f);
    }


    void Update ()
    {
        timer += Time.deltaTime;
        if (boost == true)
        {
            timeCount += Time.deltaTime;
            if (timeCount > 5f)
            { 
                boost = false;
                timeCount = 0f;
            }
            if (Input.GetButton("Fire1") && timer >= timeBetweenBullets / 3 && Time.timeScale != 0)
            {
                Shoot();
            }
            if (timer >= (timeBetweenBullets/3) * effectsDisplayTime)
            {
                DisableEffects();
            }
        }
        if (boost == false)
        {
            if (Input.GetButton("Fire1") && timer >= timeBetweenBullets && Time.timeScale != 0)
            {
                Shoot();
            }
            if (timer >= (timeBetweenBullets) * effectsDisplayTime)
            {
                DisableEffects();
            }
        }     
    }
    public void DisableEffects ()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;
    }

    void Shoot ()
    {
        timer = 0f;

        gunAudio.Play ();

        gunLight.enabled = true;

        gunParticles.Stop ();
        gunParticles.Play ();

        gunLine.enabled = true;
        gunLine.SetPosition (0, transform.position);

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        if(Physics.Raycast (shootRay, out shootHit, range, shootableMask))
        {
            EnemyHealth enemyHealth = shootHit.collider.GetComponent <EnemyHealth> ();
            if(enemyHealth != null)
            {
                enemyHealth.TakeDamage (damagePerShot, shootHit.point);
            }
            gunLine.SetPosition (1, shootHit.point);
        }
        else
        {
            gunLine.SetPosition (1, shootRay.origin + shootRay.direction * range);
        }
    }
    public void Boost()
    {
        if (boost == true)
        {
            timeCount = 0f;
        }
        boost = true;
    }
}
