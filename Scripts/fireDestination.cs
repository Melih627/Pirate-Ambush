using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireDestination : MonoBehaviour
{

    private GeneralSpeed spawner;
    private void Awake()
    {
        spawner = FindObjectOfType<GeneralSpeed>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyTimer());
    }

    // Update is called once per frame
    void Update()
    {

        FireMove();   
    }
    void FireMove()
    {
        transform.Translate(Vector3.right * Time.deltaTime * spawner.speed);
    }
    IEnumerator destroyTimer()
    {
        yield return new WaitForSeconds(17f);
        Destroy(this.gameObject);
    }
}
