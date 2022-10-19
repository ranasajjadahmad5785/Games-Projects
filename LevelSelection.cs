using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public static int levelNo;
    public GameObject[] LevelButton;
    public GameObject LevelSelectionPanel, ModeSelectionPanel, LoadingPanel;
    internal static int LevelNo;

    void Start()
    {
        Time.timeScale = 1f;
        int i = 0;
        print(PlayerPrefs.GetInt("Levels", 0) >= i);
        foreach (var item in LevelButton)
        {
            if (PlayerPrefs.GetInt("Levels", 0) >= i)
            {
                print(i);
                item.GetComponent<Button>().interactable = (true);
                item.transform.GetChild(0).gameObject.SetActive(true);
            }
            i++;
        }
           AdsScript.instance.ShowTopCentertBanner();
    }

    public void LevelSelect(int Levels)
    {
        levelNo = Levels;
        LoadingPanel.SetActive(true);
    }
    public void Back1()
    {
        SceneManager.LoadScene("MainMenuScene");
        AdsScript.instance.hideTopCenterBanner();
    }
    public void Select1()
    {
        ModeSelectionPanel.SetActive(false);
        LevelSelectionPanel.SetActive(true);
        AdsScript.instance.ShowTopCentertBanner();
    }
    public void Select2()
    {
        LevelSelectionPanel.SetActive(false);
        LoadingPanel.SetActive(true);
    }
    public void Back2()
    {
        ModeSelectionPanel.SetActive(true);
        LevelSelectionPanel.SetActive(false);
        AdsScript.instance.hideTopCenterBanner();
    }

    public void Ads1()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.apx.modern.car.driving.game");
    }
    public void Ads2()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.apx.offroad.truck.simulator.game");
    }

}

