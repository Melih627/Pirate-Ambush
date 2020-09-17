using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boatPrefab;
    [SerializeField]
    private Transform BoatStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Boatspawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Boatspawner()
    {
        Instantiate(boatPrefab, BoatStartPosition.position,Quaternion.Euler(0f,0f,-4f));
        yield return new WaitForSeconds(25f);
        StartCoroutine(Boatspawner());
    }
}
