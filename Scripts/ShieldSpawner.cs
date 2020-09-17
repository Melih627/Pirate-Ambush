using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    private float Cx1 = -5.3f;
    private float Cx2 = 6.1f;
    private float Cy = 13.5f;
    private Vector2 spawnPoint;
    [SerializeField]
    private GameObject shieldPrefab;

    [SerializeField]
    private GameObject magneticPrefab;
    private int randomItem;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSecond());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator shieldSpawn()
    {
        randomItem = Random.Range(0, 2);
        spawnPoint.x = Random.Range(Cx1, Cx2);
        spawnPoint.y = Cy;
        if (randomItem == 0)
        {
            Instantiate(shieldPrefab, spawnPoint, Quaternion.identity);
        }else if (randomItem == 1)
        {
            Instantiate(magneticPrefab, spawnPoint, Quaternion.identity);
        }
        
        yield return new WaitForSeconds(15f);
        StartCoroutine(shieldSpawn());
    }
    IEnumerator WaitSecond()
    {

        yield return new WaitForSeconds(15f);
        StartCoroutine(shieldSpawn());

    }
}
