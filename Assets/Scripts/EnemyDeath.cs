using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDeath : MonoBehaviour
{

    [SerializeField]
    GameObject mExplosionPrefab;



   


    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "Goli")
        {
            Destroy(Col.gameObject);
            Destroy(gameObject);
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);



        }

    }
}