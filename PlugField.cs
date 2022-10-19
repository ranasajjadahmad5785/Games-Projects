using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugField : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PlugField"))
        {
            player.FinishPluging2();
            player.FinishPluging3();
            player.FinishPluging4();
            player.FinishPluging6();
            player.FinishPluging7();
            player.FinishPluging8();
            player.FinishPluging9();
            player.FinishPluging10();
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
