using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
        public GameObject[] Levels, Startposition, InstructionPanel, finishPoint, vehicles, cams, fireWorks, pointDestory, arrowObjects;
        public GameObject PausePanel, ControllChange, player1,player2, Sound, waitPanel, uiController, CompletePanel, failPanel;
        public GameObject rCCam, harvesterTrigger, stopTrigger, Tayer2, Tayer3, cropperClose, cropperRotate, cropperRotattion, fieldPluged2, fieldPluged3, fieldPluged4, fieldPluged6, fieldPluged7, fieldPluged8, fieldPluged9, fieldPluged10, grassHide, slope, cutScene, ChangeVehicle, /*water*/ waterSpray;
        public GameObject grassBundle, shugarCaneBundle, Buildings;
        public static bool trucksound;
        public Player Game;
        public Animator[] backDoor, vehiclesAnimations;
        private bool isSteering = true;
        int CurrentLevel, ind;
        public Text LevelNoTxt;
        internal object feild;
        public GameObject[] Dust;

        void Start()
        {
                LevelSelection.LevelNo = 4;
                Time.timeScale = 1f;
                Levels[LevelSelection.LevelNo].SetActive(true);
                CurrentLevel = LevelSelection.LevelNo;
                player1.gameObject.SetActive(true);
                Levels[LevelSelection.LevelNo].SetActive(true);
                LevelNoTxt.text = (LevelSelection.LevelNo + 1).ToString();
                player1.gameObject.transform.position = Startposition[LevelSelection.LevelNo].transform.position;
                player1.gameObject.transform.rotation = Startposition[LevelSelection.LevelNo].transform.rotation;
                foreach (var item in Levels)
                {
                    item.SetActive(false);
                }
                Levels[CurrentLevel].SetActive(true);
                if (LevelSelection.LevelNo == 0)
                {
                    cutScene.SetActive(true);
                    Buildings.SetActive(false);
                    vehiclesAnimations[3].SetBool("CS", true);
                    uiController.SetActive(false);
                    StartCoroutine(cutScenewait());
                }
                if (LevelSelection.LevelNo == 1 )
                {
                    player2.gameObject.SetActive(true);
                    InstructionPanel[1].SetActive(true);
                    player2.gameObject.transform.position = Startposition[LevelSelection.LevelNo].transform.position;
                    player2.gameObject.transform.rotation = Startposition[LevelSelection.LevelNo].transform.rotation;
                }
                if (LevelSelection.LevelNo == 2)
                {
                    player2.gameObject.SetActive(true);
                    InstructionPanel[2].SetActive(true);
                }
                if (LevelSelection.LevelNo == 3)
                {
                  InstructionPanel[3].SetActive(true);
                }
                if (LevelSelection.LevelNo == 4)
                {
                    Buildings.SetActive(false);
                    InstructionPanel[4].SetActive(true);
                }
                if (LevelSelection.LevelNo == 5)
                {
                    InstructionPanel[5].SetActive(true);
                }
                if (LevelSelection.LevelNo == 6)
                {
                    InstructionPanel[6].SetActive(true);
                }
                if (LevelSelection.LevelNo == 7)
                {
                    InstructionPanel[7].SetActive(true);
                }
                if (LevelSelection.LevelNo == 8)
                {
                    InstructionPanel[8].SetActive(true);
                }
                if (LevelSelection.LevelNo == 9)
                {
                    InstructionPanel[9].SetActive(true);
                }
                if (LevelSelection.LevelNo == 10)
                {
                    InstructionPanel[10].SetActive(true);
                }
                IEnumerator cutScenewait()
                {
                    yield return new WaitForSeconds(6f);
                    vehiclesAnimations[3].SetBool("CS", false);
                    cutScene.SetActive(false);
                    uiController.SetActive(true);
                    backDoor[0].SetBool("BackDoor", false);
                    InstructionPanel[0].SetActive(true);
                }
                foreach (var item in Levels)
                {
                  item.SetActive(false);
                }
                Levels[CurrentLevel].SetActive(true);
                PlayerPrefs.SetInt("fromplay", 0);
                if (PlayerPrefs.GetInt("sound") == 0)
                {
                    trucksound = false;
                    Sound.SetActive(true);
                }
                 //AdsScript.instance.hideTopcenter(); 
        }
        public void RaceDown()
        {
            player1.GetComponent<Rigidbody>().drag = 0.09f;
            player2.GetComponent<Rigidbody>().drag = 0.09f;
        }

        public void RaceUp()
        {
            player1.GetComponent<Rigidbody>().drag = 1f;
            player1.GetComponent<Rigidbody>().drag = 1f;
        }
        public void replay()
        {
            SceneManager.LoadScene("GamePlayScene");
            AdsScript.instance.hideTopCenterBanner();
        }
        public void ChangeController()
        {
            if (isSteering)
            {
                RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
                isSteering = false;
            }
            else
            {
                RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
                isSteering = true;
            }
        }
        public void resume()
        {
                Time.timeScale = 1.0f;
                PausePanel.SetActive(false);
                AdsScript.instance.hideTopCenterBanner();
        }
        public void home()
        {
            SceneManager.LoadScene("MainMenuScene");
        }
        public void Pause()
        {
            PausePanel.SetActive(true);
            Time.timeScale = 1.0f;
            AdsScript.instance.ShowTopCentertBanner();
            AdsScript.instance.showAdmobInterstitial();
        }
        public void next()
        {
                if (LevelSelection.LevelNo >= 10)
                {
                SceneManager.LoadScene("LevelSelectionScene");

                }
                else
                {
                  CurrentLevel++;
                  LevelSelection.LevelNo++;
                  SceneManager.LoadScene("GamePlayScene");
                }
        }
        public void VehicleControllChange()
        {
            vehicles[36].SetActive(false);
            vehicles[37].SetActive(false);
            vehicles[38].SetActive(true);
        }
        public void OK()
        {
               vehicles[1].GetComponent<RCC_CarControllerV3>().enabled = true;
               cams[1].SetActive(false);
               cams[2].SetActive(false);
               rCCam.SetActive(true);
               InstructionPanel[0].SetActive(false);
               InstructionPanel[1].SetActive(false);
               InstructionPanel[2].SetActive(false);
               InstructionPanel[3].SetActive(false);
               InstructionPanel[4].SetActive(false);
               InstructionPanel[5].SetActive(false);
               InstructionPanel[6].SetActive(false);
               InstructionPanel[7].SetActive(false);
               InstructionPanel[8].SetActive(false);
               InstructionPanel[9].SetActive(false);
               InstructionPanel[10].SetActive(false);
        }

}