using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneticPlayerTrigger : MonoBehaviour
{

    [SerializeField]
    private characterController playerTarget;
    [SerializeField]
    private GameObject particlePrefab;
    private void Awake()
    {
        playerTarget = FindObjectOfType<characterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(dieTime());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(particlePrefab, playerTarget.transform.position, Quaternion.identity);
            if (!collision.gameObject.GetComponent<Transform>().GetChild(13).gameObject.activeSelf)
            {
                playerTarget.GetComponent<Transform>().GetChild(13).gameObject.SetActive(true);
                Destroy(this.gameObject);
            }
            else if (collision.gameObject.GetComponent<Transform>().GetChild(13).gameObject.activeSelf)
            {
                playerTarget.GetComponent<Transform>().GetChild(13).gameObject.SetActive(true);
                Destroy(this.gameObject);
            }

        }
    }
    IEnumerator dieTime()
    {
        yield return new WaitForSeconds(10f);
        Color tmp = this.gameObject.GetComponent<Transform>().GetChild(0).gameObject.GetComponent<SpriteRenderer>().color;
        tmp.a = 0f;
        this.gameObject.GetComponent<Transform>().GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = tmp;
        yield return new WaitForSeconds(0.3f);
        tmp.a = 1f;
        this.gameObject.GetComponent<Transform>().GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = tmp;
        yield return new WaitForSeconds(0.3f);
        tmp.a = 0f;
        this.gameObject.GetComponent<Transform>().GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = tmp;
        yield return new WaitForSeconds(0.3f);
        tmp.a = 1f;
        this.gameObject.GetComponent<Transform>().GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = tmp;
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }
}
