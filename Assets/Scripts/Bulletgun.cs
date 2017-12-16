using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bulletgun : MonoBehaviour {

    public GameObject BulletPrefab;
    public float fireDelay = 0.25f;
    float cooldown = 0;


    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (Input.GetButton("Fire1") && cooldown <= 0)
        {
            Debug.Log("Shoot");
            cooldown = fireDelay;
            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}