using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticCont : MonoBehaviour
{
    private float magneticSpeed=6f;
    [SerializeField]
    private GameObject[] backGroundSprites;
    private Color WhiteColor = new Color(255f / 255.0f, 255f / 255.0f, 255f / 255.0f);
    private Color PurpleColor = new Color(105f / 255.0f, 10f / 255.0f, 135f / 255.0f);
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
        StartCoroutine(magneticRecoil());
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            if (collision.gameObject.GetComponent<magneticCalculate>().isUp)
            {
                collision.gameObject.transform.Translate(Vector3.down * Time.deltaTime * magneticSpeed);
            }
            else if (!collision.gameObject.GetComponent<magneticCalculate>().isUp)
            {
                collision.gameObject.transform.Translate(Vector3.up * Time.deltaTime * magneticSpeed);
            }


        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            if (collision.gameObject.GetComponent<magneticCalculate>().isUp)
            {
                collision.gameObject.transform.Translate(Vector3.down * Time.deltaTime * magneticSpeed);
            }
            else if (!collision.gameObject.GetComponent<magneticCalculate>().isUp)
            {
                collision.gameObject.transform.Translate(Vector3.up * Time.deltaTime * magneticSpeed);
            }

        }
    }
    IEnumerator magneticRecoil()
    {
        foreach (var sprite in backGroundSprites)
        {
            sprite.GetComponent<SpriteRenderer>().color = PurpleColor;
        }
        yield return new WaitForSeconds(5f);
        foreach (var sprite in backGroundSprites)
        {
            sprite.GetComponent<SpriteRenderer>().color =WhiteColor;
        }
        this.gameObject.SetActive(false);
    }
}
