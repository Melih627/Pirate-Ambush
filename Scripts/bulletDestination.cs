using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestination : MonoBehaviour
{
    private float speed = 13f;
    private Rigidbody2D rg;
    [SerializeField]
    private EnemyHealthBar enemy;
    [SerializeField]
    private GameObject explosionPrefab;
    private Color colorA =new Color(0f,0f,0f);
    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
        enemy = FindObjectOfType<EnemyHealthBar>();
    }
    // Start is called before the first frame update
    void Start()
    {
        colorA.a = 0f;
        rg.velocity = transform.right * speed;
        StartCoroutine(destroyObj());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy" && enemy.gameObject.GetComponent<EnemyHealthBar>().canTakeDamage)
        { 
            GameObject expObj = Instantiate(explosionPrefab, this.gameObject.transform.position,Quaternion.identity);
            this.gameObject.GetComponent<SpriteRenderer>().color = colorA; 
            StartCoroutine(destroyExp(expObj));
            enemy.gameObject.GetComponent<EnemyHealthBar>().slider.value -= 0.01f;
            
        }
    }
    IEnumerator destroyObj()
    {
        yield return new WaitForSeconds(10f);
        Destroy(this.gameObject);
    }
    
    IEnumerator destroyExp(GameObject obj)
    {
        yield return new WaitForSeconds(1f);
        Destroy(obj);
        Destroy(this.gameObject);
    }
   
}
