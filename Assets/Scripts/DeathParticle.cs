using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticle : MonoBehaviour {

    [SerializeField]
    GameObject mExplosionPrefab;


    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "enemy")
        {
            Destroy(Col.gameObject);
            Destroy(gameObject);
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);



        }
    }
}