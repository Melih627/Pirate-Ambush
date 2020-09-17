using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyObj()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(4f);
    }
}
