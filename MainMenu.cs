using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject MainMunePannel, SettingPanel, ExitPanel, StreeingButton, TuchScreenButton, leftRightButton;
    public AudioSource music, sound;
    public Slider musicSlider, soundSlider;
    void Start()
    {
        Time.timeScale = 1f;
        if (PlayerPrefs.GetInt("1") != 1)
        {
            musicSlider.value = music.volume = 1.0f;
            soundSlider.value = sound.volume = 1.0f;
        }
        if (PlayerPrefs.GetInt("MobileController") == 0)
        {
            StreeingButton.SetActive(true);
            TuchScreenButton.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("MobileController") == 1)
        {
            TuchScreenButton.SetActive(true);
            StreeingButton.SetActive(false);
        }
        AdsScript.instance.ShowTopCentertBanner();
    }
    public void MainMenue()
    {
        MainMunePannel.SetActive(true);
    }
    public void Garage()
    {
        SceneManager.LoadScene("GarageScene");
    }
    public void Play()
    {
        SceneManager.LoadScene("LevelSelectionScene");
        AdsScript.instance.ShowTopCentertBanner();
    }
    public void More()
    {
        Application.OpenURL("https://play.google.com/store/apps/collection/cluster?clp=igM4ChkKEzU2NDk3NDY2MjYxMDAyMDQ1MDkQCBgDEhkKEzU2NDk3NDY2MjYxMDAyMDQ1MDkQCBgDGAA%3D:S:ANO1ljLaYHU&gsr=CjuKAzgKGQoTNTY0OTc0NjYyNjEwMDIwNDUwORAIGAMSGQoTNTY0OTc0NjYyNjEwMDIwNDUwORAIGAMYAA%3D%3D:S:ANO1ljJbAtE");
    }
    public void Rateus()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=" + Application.identifier);
    }
    public void Privacy()
    {
        Application.OpenURL("https://officialbraingames.blogspot.com/2022/09/privacy-policy-for-brain-games-inc.html");
    }
    public void Back()
    {
        SettingPanel.SetActive(false);
        MainMunePannel.SetActive(true);
        AdsScript.instance.hideTopCenterBanner();
    }
    public void Back1()
    {
        ExitPanel.SetActive(false);
        MainMunePannel.SetActive(true);
        AdsScript.instance.hideTopCenterBanner();
    }
    public void Back2()
    {
        MainMunePannel.SetActive(true);
        SettingPanel.SetActive(false);
        AdsScript.instance.hideTopCenterBanner();
    }
    public void StartButton()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void Setting()
    {
        MainMunePannel.SetActive(false);
        SettingPanel.SetActive(true);
        AdsScript.instance.ShowTopCentertBanner();
    }
    public void MusicControl()
    {
        PlayerPrefs.SetFloat("Music", musicSlider.value);
        music.volume = PlayerPrefs.GetFloat("Music");
    }
    public void SoundControl()
    {
        PlayerPrefs.SetFloat("Sound", soundSlider.value);
        sound.volume = PlayerPrefs.GetFloat("Sound");
    }

    public void Streenig()
    {
        PlayerPrefs.SetInt("MobileController", 0);
        {
            RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
        }
    }
    public void TuchScreen()
    {
        PlayerPrefs.SetInt("MobileController", 1);
        {
            RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
        }
    }
    public void Musicon()
    {
        PlayerPrefs.SetInt("Sound", 1);
        AudioListener.volume = 1f;
    }
    public void Musicoff()
    {
        PlayerPrefs.SetInt("Sound", 0);
        AudioListener.volume = 0f;
    }
    public void Exit()
    {
        MainMunePannel.SetActive(false);
        ExitPanel.SetActive(true);
        AdsScript.instance.hideTopCenterBanner();
    }
    public void Yes()
    {
        Application.Quit();
    }
    public void No()
    {
        ExitPanel.SetActive(false);
        MainMunePannel.SetActive(true);
        AdsScript.instance.hideTopCenterBanner();
    }
    public void Ad1()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.apx.offroad.city.truck.simulator.truck.games");
    }
    public void Ad2()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.apx.offroad.city.truck.simulator.truck.games");
    }

    public void Ad3()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.ss.mobile.bus.wash.city.transport");
    }

    public void Ad4()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.ss.Carparking.multipayer");
    }

    public void Ad5()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.ss.police.multi.advance.auto.cop.parking");
    }

    public void OpenLink(string url)
    {
        Application.OpenURL(url);
    }
}
