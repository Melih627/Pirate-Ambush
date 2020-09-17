using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneticCalculate : MonoBehaviour
{
    [SerializeField]
    private MagneticCont magneticField;
    [SerializeField]
    private characterController targetPlayer;

    private float distanceY=0f;
    public bool isUp=false;

    private void Awake()
    {
        targetPlayer = FindObjectOfType<characterController>();
        magneticField = FindObjectOfType<MagneticCont>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        magneticField = FindObjectOfType<MagneticCont>();
        if (targetPlayer.gameObject.GetComponent<Transform>().GetChild(13).gameObject.activeSelf)
        {

            distanceY = transform.position.y - magneticField.gameObject.transform.position.y;
            if (distanceY >= 0)
            {
                isUp = true;
            } else if (distanceY < 0)
            {
                isUp = false;
            }
        }
        
        
    }
}
