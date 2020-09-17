using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSpeed : MonoBehaviour
{

    public Text ScoreText;
    public  float speed = 11.5f;
    private float timeCounter=15f;
    public int Score=0;
    // Start is called before the first frame update
     void Start()
    {
        StartCoroutine(ScoreTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeCounter)
        {
            speed += 0.5f;
            timeCounter = Time.time + 15f;
        }
    }
    
    IEnumerator ScoreTimer()
    {
        if (Score < 10)
        {
            ScoreText.text = "SURVIVAL TIME : 0" + Score.ToString();
        }
        else
        {
            ScoreText.text = "SURVIVAL TIME : " + Score.ToString();
        } 
        
        yield return new WaitForSeconds(1f);
        Score++;
        StartCoroutine(ScoreTimer());
    }
}
