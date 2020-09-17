using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityIncrease : MonoBehaviour
{
    [SerializeField]
    private GravityControl gravityControl;
    private Rigidbody2D rg;
    private void Awake()
    {
        gravityControl = FindObjectOfType<GravityControl>();
        rg = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rg.gravityScale = gravityControl.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
