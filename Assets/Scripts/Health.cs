using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    GameObject mExplosionPrefab;
    [SerializeField]
    GameObject m2ExplosionPrefab;

    public Image HealthBar;
    public float Healthy = 1;
    bool dead = false;
    bool startSceneTimer = false;
    float timer = 2f;

    AudioSource stateru;


    void Start()
    {
        stateru = GetComponents<AudioSource>()[1];
    }

    void Update()
    {

        HealthBar.fillAmount = Healthy;
        if (Healthy <= 0f && dead == false)
        {
            Debug.Log("poop");


            stateru.Play();
            Destroy(gameObject, 3);
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            startSceneTimer = true;
            dead = true;


        }
        if (startSceneTimer)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            Debug.Log("c");
            SceneManager.LoadScene("Game Over");
            Destroy(gameObject);
        }
    }



    void TakeDamage(int damage)
    {
        Debug.Log("Taking Damage: " + damage);
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.layer == LayerMask.NameToLayer("enemy"))
        {
            Instantiate(m2ExplosionPrefab, transform.position, Quaternion.identity);
            Healthy -= .40f;

            Destroy(obj.gameObject);
        }
        
    }
}