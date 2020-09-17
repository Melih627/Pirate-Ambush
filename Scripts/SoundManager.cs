using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SoundManager : MonoBehaviour
{
    public static bool isPlaysound=true;
    [SerializeField]
    private GameObject offbutton;
    [SerializeField] 
    private GameObject onButton;
    [SerializeField]
    private AudioSource audioSource;





    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        offbutton.SetActive(true);
        onButton.SetActive(false);
    }

  
    public void soundOn()
    {
        isPlaysound = !isPlaysound;
        if (isPlaysound)
        {
            offbutton.SetActive(true);
            onButton.SetActive(false);
        }
        
    }
    public void soundOff()
    {
        isPlaysound = !isPlaysound;
        if (!isPlaysound)
        {
            offbutton.SetActive(false);
            onButton.SetActive(true);
        }
    }
}
