using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject sharkPrefabLtoR;
    [SerializeField]
    private GameObject sharkPrefabRtoL;
    [SerializeField]
    private Transform position1_L;
    [SerializeField]
    private Transform position2_R;
    private float randomPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sharkSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator sharkSpawn()
    {
        randomPosition = Random.Range(0, 2);
        if (randomPosition == 0)
        {
            Instantiate(sharkPrefabLtoR, position1_L.position,Quaternion.Euler(0f,180f,-9f));
        }else if (randomPosition==1)
        {
            Instantiate(sharkPrefabRtoL, position2_R.position, Quaternion.Euler(0f, 0f, -9f));
        }

        yield return new WaitForSeconds(35f);
        StartCoroutine(sharkSpawn());
    }
}
