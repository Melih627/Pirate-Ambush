using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRtoL : MonoBehaviour
{
    private float Shark_Speed = 2f;
    private Vector3 moveDest;
    [SerializeField]
    private GameObject RtoL;
    // Start is called before the first frame update
    void Start()
    {
        RtoL = GameObject.FindGameObjectWithTag("pos2");
        moveDest.y = RtoL.transform.position.y;
        moveDest.z = RtoL.transform.position.z;
        moveDest.x = RtoL.transform.position.x;
        StartCoroutine(destroyObj());
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDest.x -= Time.deltaTime * Shark_Speed;
        transform.position = moveDest;
    }
    IEnumerator destroyObj()
    {
        yield return new WaitForSeconds(30f);
        Destroy(this.gameObject);
    }
}
