using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLtoR : MonoBehaviour
{
    private float Shark_Speed = 2f;
    private Vector3 moveDest;
    [SerializeField]
    private GameObject LtoR;
    // Start is called before the first frame update
    void Start()
    {
        LtoR = GameObject.FindGameObjectWithTag("pos1");
        moveDest.y = LtoR.transform.position.y;
        moveDest.z = LtoR.transform.position.z;
        moveDest.x = LtoR.transform.position.x;
        StartCoroutine(destroyObj());

    }

    // Update is called once per frame
    void Update()
    {
        moveDest.x += Time.deltaTime * Shark_Speed;
        transform.position = moveDest;
    }
    IEnumerator destroyObj()
    {
        yield return new WaitForSeconds(30f);
        Destroy(this.gameObject);
    }
}
