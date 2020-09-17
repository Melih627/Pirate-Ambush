using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatDestination : MonoBehaviour
{
    private float boatSpeed = 1f;
    private Vector3 boatMove;
    // Start is called before the first frame update
    void Start()
    {
        boatMove = new Vector3(-1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += boatMove * boatSpeed * Time.deltaTime;
    }

    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(25f);
        Destroy(this.gameObject);
    }
}
