using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class fireballSpawner : MonoBehaviour
{
    [SerializeField]
    private characterController Target;
    private Vector3 spawnPoint;
    [SerializeField]
    private GameObject FirePrefab;
    private float randomY;
    private Vector3 cannonPos= Vector3.zero;
    [SerializeField]
    private GameObject firePoint;
    [SerializeField]
    private EnemyHealthBar enemy;

    private void Awake()
    {
        Target = FindObjectOfType<characterController>();
        enemy = FindObjectOfType<EnemyHealthBar>();
    }
    // Start is called before the first frame update
    void Start()
    {
        cannonPos.x = 18.69f;
        cannonPos.y = -4.99f;
        StartCoroutine(rec());
        
    }
    private void Update()
    {
        
        //spawnPoint.x += 25f;
        //randomY = Random.Range(0.01f, 0.073f);
        //randomY = Random.Range(-0.15f, 0.4f);
        //spawnPoint.y -= randomY;
    }

    IEnumerator FireSpawner()
    {
        if (enemy.gameObject.GetComponent<EnemyHealthBar>().canFireCannon)
        {
            Instantiate(FirePrefab, firePoint.transform.position, firePoint.transform.rotation);          
        }
        yield return new WaitForSeconds(1.05f);
        StartCoroutine(FireSpawner());

    }
    IEnumerator rec()
    {

        yield return new WaitForSeconds(2f);
        StartCoroutine(FireSpawner());
    }
}
