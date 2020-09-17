using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobManagerShowInterstitial : MonoBehaviour
{
    private RewardedAd rewardedAd;
    private InterstitialAd interstitial;
    private void Start()
    {
        
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        this.RequestInterstitial();
        this.RequestRewardedAds();
        
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
        
    }
    private void RequestRewardedAds()
    {
        string RewardedadUnitID = "ca-app-pub-3940256099942544/5224354917";
        this.rewardedAd = new RewardedAd(RewardedadUnitID);
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }
    public void ShowAdMob()
    {
        int randomAdNumber = Random.Range(0, 2);
        if (randomAdNumber == 0)
        {
            if (PlayerPrefs.GetInt("_adMobCount") % 3 == 0)
            {
                interstitial.Show();
            }
        }
        else if (randomAdNumber == 1)
        {
            if (PlayerPrefs.GetInt("_adMobCount") % 3 == 0)
            {
                rewardedAd.Show();
            }
            
        }
        PlayerPrefs.SetInt("_adMobCount", (PlayerPrefs.GetInt("_adMobCount") + 1));

    }


}
