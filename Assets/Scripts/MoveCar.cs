using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {

    public float RotateSpeed = 100;
    
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * RotateSpeed);
            //transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed * 2
            //transform.Rotate += new Vector3(0, 0, -1) * Time.deltaTime * RotateSpeed * 2;
            //            transform.Rotate(Vector3(0,0,1).up * Time.deltaTime * -RotateSpeed, Space.Self);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * RotateSpeed);
            //transform.Rotate += new Vector3(0, 0, 1) * Time.deltaTime * RotateSpeed * 2;
            //transform.Rotate(Vector3(0,0,1).up * Time.deltaTime * RotateSpeed, Space.Self);
        }
    }
}
