using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDestination : MonoBehaviour
{
    private float windSpeed = 0.5f;
    private Vector3 cloudDestination;
    // Start is called before the first frame update
    void Start()
    {
        cloudDestination = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cloudDestination.x += Time.deltaTime * windSpeed;
        this.gameObject.transform.position =cloudDestination;
    }
 
    

}
