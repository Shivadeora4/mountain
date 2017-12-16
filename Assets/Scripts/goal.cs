using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.CompareTag("Player"))
        {
            Debug.Log("GAME WON! :D");
            SceneManager.LoadScene("Scenes2");
        }
    }
}