using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnanControl : MonoBehaviour
{
    [SerializeField]
    private Transform Player;
    Vector2 direction;
    Quaternion rotation;
    float angle;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        cannonRotate();

    }
    void cannonRotate()
    {
        
        direction = Player.position - transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1f);
    }

}
