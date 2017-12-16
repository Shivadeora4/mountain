using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsBurst : MonoBehaviour
{
    [SerializeField]
    
    public Text ScoreText;

    static int score = 0;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            score++;
            ScoreText.text = "Coins:" + score;
        }
    }
}

