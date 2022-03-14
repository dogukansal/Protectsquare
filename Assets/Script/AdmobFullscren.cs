using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdmobFullscren : MonoBehaviour
{
    private InterstitialAd interstitial;
    void Start()
    {
        MobileAds.Initialize(initStatus => { });

        this.RequestInterstitial();
    }

    

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-/";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-/";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        reklamiyukle();


    }
    public void reklamiyukle()

    {
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
        
    }
    public void GameOver()

    {
        
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
