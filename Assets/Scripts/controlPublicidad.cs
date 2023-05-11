using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class controlPublicidad : MonoBehaviour, IUnityAdsListener
{
    private ControlHUD controlhud;

#if UNITY_IOS
    public string gameId = "5215633";
#elif UNITY_ANDROID
    public string gameId = "5215632";
#elif UNITY_EDITOR
    public string gameId = "5215632";
#endif

    public string placementId = "Anuncio";

    public static controlPublicidad instancia;

    private void Awake()
    {
        instancia = this;
    }

    public void mostrarPublicidad()
    {
        Advertisement.Show(placementId);
    }

    public void OnUnityAdsDidError(string message)
    {
        
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
        controlhud = FindObjectOfType<ControlHUD>();
    }

}
