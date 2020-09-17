﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCont : MonoBehaviour
{
    [SerializeField]
    private SonucManager sonucM;
    private void Awake()
    {
        sonucM = FindObjectOfType<SonucManager>();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.transform.tag == "Player")
    //    {
    //        sonucM.GetComponent<SonucManager>().isResult = true;
            
    //    }
       

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            sonucM.GetComponent<SonucManager>().isResult = true;

        }
    }
}