using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScalerCont : MonoBehaviour
{
    [SerializeField]
    private CanvasScaler canvasScaler;
    private float resX;
    private float resY;
    // Start is called before the first frame update
    void Start()
    {
        canvasScaler = GetComponent<CanvasScaler>();
        SetInfo();
    }

    // Update is called once per frame
    void SetInfo()
    {
        resX = (float)Screen.currentResolution.width;
        resY = (float)Screen.currentResolution.height;
        canvasScaler.referenceResolution = new Vector2(resX , resY);

    }
    //private void Update()
    //{
    //    resX = (float)Screen.currentResolution.width;
    //    resY = (float)Screen.currentResolution.height;
    //    canvasScaler.referenceResolution = new Vector2(resX, resY);
    //}
}
