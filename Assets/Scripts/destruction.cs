using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class destruction : MonoBehaviour
{
    bool statrtScene = false;
    float timer = 0.5f;

    public GameObject mDeathParticleEmitter;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("ground"))
        {

            Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
            GameObject parent = transform.parent.gameObject;
            transform.parent = null;
            Destroy(parent);
            statrtScene = true;

        }
    }
    void Update()
    {
        if (statrtScene)
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
