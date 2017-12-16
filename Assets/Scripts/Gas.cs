using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gas : MonoBehaviour
{
    
    public Image GasBar;
    public float GasValue = 1;

    float timedEvent = 1;
    float timeTracker = 0;
    bool isMove = false;

    Car car;

    // Use this for initialization
    void Start()
    {
        car = GameObject.Find("Car").GetComponent<Car>();

    }

    // Update is called once per frame
    void Update()
    {
        GasBar.fillAmount = GasValue;

        timeTracker += Time.deltaTime;
        if (timeTracker >= timedEvent)
        {
            if (GasValue > 0.1f)
            {
                GasValue -= 0.20f;
                timeTracker -= timedEvent;
            }
            else
            {
                car.Die();
                SceneManager.LoadScene("Game Over");

            }
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == LayerMask.NameToLayer("Fuel1"))
        {
            GasValue += 1f;
            Destroy(coll.gameObject);
        }


    }
}
