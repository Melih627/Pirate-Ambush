using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    characterController target;
    Vector3 offset;
    Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<characterController>();
        offset = transform.position - target.transform.position;
        targetPos = target.transform.position;
        targetPos.y = target.transform.position.y;
    }

    // Update is called once per frame
   private void Update()
    {
        targetPos.x = target.transform.position.x;
        targetPos.z = target.transform.position.z;
        transform.position = targetPos + offset;
    }
}
