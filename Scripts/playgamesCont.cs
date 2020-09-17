using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playgamesCont : MonoBehaviour
{
    public Text mainText;
    // Start is called before the first frame update
    void Start()
    {
        AuthenticateUser();
    }
    void AuthenticateUser()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success == true)
            {
                Debug.Log("logged in to google play games services");
                SceneManager.LoadScene("MenuLevel");
            }
            else
            {
                Debug.LogError("unable to sign in to google play games services");
                mainText.text = "Could not login to google play games services";
                mainText.color = Color.red;
            }
        });
    }

    public static void PostToLeaderboard(long newScore)
    {
        Social.ReportScore(newScore, GPGSIds.leaderboard_top_10_highscores, (bool success) => {

            if (success)
            {
                Debug.Log("Posted new score to leaderboard");
            }
            else
            {
                Debug.LogError("unable to post new score to leaderboard");
            }
        });
    }

    public static void ShowLeaderboardUI()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI(GPGSIds.leaderboard_top_10_highscores);
    }
}
