using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksDestroy : MonoBehaviour
{
    public GameObject[] fireWorks;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destroy")
        {
            fireWorks[0].SetActive(false);
        }
    }

}
