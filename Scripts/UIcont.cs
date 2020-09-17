using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcont : MonoBehaviour
{
    public Text scoreText;
    public Text errorText;
    // Start is called before the first frame update
    void Start()
    {
        errorText.text = "";
    }

    public void OnButtonPostToLeaderboard()
    {
        Debug.Log("posting score to leader");
        errorText.text = "";
        if (string.IsNullOrEmpty(scoreText.text))
        {
            errorText.text = "Error : Could not post score to leaderboard. please enter a value in the score input field";
            return;
        }
        else
        {
            long scoreToPost;
            if(long.TryParse(scoreText.text,out scoreToPost))
            {
                playgamesCont.PostToLeaderboard(scoreToPost);
            }
            else
            {
                errorText.text = "Error : Could not post score to leaderboard. please enter a valid score value";
            }
        }
    }
    public void OnbuttonShowLeaderboard()
    {
        Debug.Log("showing leaderboard");
        playgamesCont.ShowLeaderboardUI();
    }
}
