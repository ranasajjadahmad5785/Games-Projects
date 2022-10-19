using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public float delaytime;
    public Text m_Text;
    public string Scenename;
    public Slider Loadingbar;
    void Start()
    {
        //Time.timeScale = 1f;
        Invoke("Load", delaytime);
        //AdsScript.instance.showAdmobInterstitial();
    }
    private void Load()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
    IEnumerator LoadYourAsyncScene()
    {
        yield return null;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(Scenename);
        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone)
        {
            m_Text.text = "Loading: " + (asyncOperation.progress * 100) + "%";
            Loadingbar.value = asyncOperation.progress;
            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
