using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{


    public float MovementSpeed = 1;
    public float RotateSpeed = 1;
    bool isMove = true;


    public AudioSource stater;

     void Start()
    {
        stater = GetComponent<AudioSource>();
    }



    void Update()  //Runs at every Frame.
    {



        if (isMove == true)
        {
            // Obtain input information (See "Horizontal" and "Vertical" in the Input Manager)
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            // ALTERNATIVE
            // Forward And Backward


            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                stater.Play();
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * MovementSpeed;
                //  transform.Rotate(Vector3.up * Time.deltaTime * RotateSpeed, Space.Self);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;
            }
            // Rotation

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * RotateSpeed);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * RotateSpeed);
            }



        }
        else
        {
            return;
        }

    }
    public void Die()
    {
        isMove = false;
    }
}
