using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Cloud01Prefab ,Cloud03Prefab;
    [SerializeField]
    private Transform Cloud01Transform, Cloud03Transform;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cloudSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator cloudSpawn()
    {
        Instantiate(Cloud01Prefab, Cloud01Transform.position, Quaternion.identity);
        Instantiate(Cloud03Prefab, Cloud03Transform.position, Quaternion.identity);
        yield return new WaitForSeconds(50f);
        StartCoroutine(cloudSpawn());
    }
}
