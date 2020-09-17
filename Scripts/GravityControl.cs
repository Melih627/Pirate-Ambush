using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    public float gravityScale=0.03f;
    private float timeCounter=15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeCounter)
        {
            gravityScale += 0.02f;
            timeCounter = Time.time + 15f;
        }

    }
}
