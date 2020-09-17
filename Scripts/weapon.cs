using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject firePoint;
    private float fireRate=1.75f;
    private float timeCount = 0f;
    protected JoyButtonFire joyButtonFire;
    private bool fire;

    // Start is called before the first frame update
    void Start()
    {
        joyButtonFire = FindObjectOfType<JoyButtonFire>();
        fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!fire &&joyButtonFire.Pressed && Time.time > timeCount)
        {
            fire = true;
            Instantiate(bulletPrefab, firePoint.transform.position,firePoint.transform.rotation);
            timeCount = Time.time + 1f / fireRate;
        }
        if(fire && !joyButtonFire.Pressed)
        {
            fire = false;
        }
    }
    
}
