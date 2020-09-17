using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldControl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] backGroundSprites;
    private Color WhiteColor = new Color(255f / 255.0f, 255f / 255.0f, 255f / 255.0f);
    private Color BlueColor = new Color(31f/ 255.0f, 90f / 255.0f, 152f / 255.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        StartCoroutine(shieldRecoil()); 

    }
    IEnumerator shieldRecoil()
    {
        foreach (var sprite in backGroundSprites)
        {
            sprite.GetComponent<SpriteRenderer>().color = BlueColor;
        }

        yield return new WaitForSeconds(4f);
        foreach (var sprite in backGroundSprites)
        {
            sprite.GetComponent<SpriteRenderer>().color = WhiteColor;
        }
        this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            Destroy(collision.gameObject);
        }
    }
}
