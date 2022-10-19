using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsMover : MonoBehaviour
{
    public GameObject[] Arrow;
    public float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        EnableAll();
        yield return new WaitForSeconds(delayTime);
        DisableAll();
        StartCoroutine("Delay");
    }

    void EnableAll()
    {
        for (int i = 0; i < Arrow.Length; i++)
        {
            Arrow[i].SetActive(true);
        }
    }

    void DisableAll()
    {
        for (int i = 0; i < Arrow.Length; i++)
        {
            Arrow[i].SetActive(false);
        }
    }
}
