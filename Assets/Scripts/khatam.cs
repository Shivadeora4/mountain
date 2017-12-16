using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class khatam : MonoBehaviour {
    bool statrtiScene = false;
    float timer = 2f;

  
    public GameObject mDeathParticleEmitter;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("khatma"))
        {

            Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
            statrtiScene = true;
            Destroy(gameObject,3);
            
        }

    }
    void Update()
    {
        if (statrtiScene)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("Game Over");
            Destroy(gameObject);
        }
    }
}
