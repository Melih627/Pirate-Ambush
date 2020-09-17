using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlyShowLeaderboard : MonoBehaviour
{
    
    
    public void OnbuttonShowLeaderboard()
    {
        Debug.Log("showing leaderboard");
        playgamesCont.ShowLeaderboardUI();
    }
}
