using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Setting Up Some Score Value When Player Collected The Keys...
public class ScoreController : MonoBehaviour
{
    [SerializeField] public Text scoreText;

    private int score = 0;

    private void Start()
    {
        score = 0;
        scoreText.text = "0" + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "LowerBoundry")
        {
            score += 1;
            scoreText.text = "0" + score;
        }
     } 

}