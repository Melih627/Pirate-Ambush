using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{

    public bool isResult;
    [SerializeField]
    private GameObject sonucPanel;

    [SerializeField]
    private GeneralSpeed generalSpeed;

    [SerializeField]
    private Text sonucTxt;

    [SerializeField]
    private GameObject pauseButton;
    [SerializeField]
    private GameObject scoreText;
    [SerializeField]
    private GameObject googlePlayscore;
    private void Awake()
    {
        generalSpeed = FindObjectOfType<GeneralSpeed>();
        isResult = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isResult)
        {
            
            if (generalSpeed.GetComponent<GeneralSpeed>().Score < 10)
            {
                sonucTxt.text ="0" +generalSpeed.GetComponent<GeneralSpeed>().Score.ToString();
            }
            else
            {
                sonucTxt.text = generalSpeed.GetComponent<GeneralSpeed>().Score.ToString();
            }
            googlePlayscore.GetComponent<UIcont>().OnButtonPostToLeaderboard();
            pauseButton.SetActive(false);
            scoreText.SetActive(false);
            sonucPanel.SetActive(true);
            Time.timeScale = 0;
        }

    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MenuLevel");
    }
    public void retryGame()
    {
        SceneManager.LoadScene("SampleScene");
        
    }



}
