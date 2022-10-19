using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour 
{
	public static float tmer;
	public Text time;

	void Start ()
	{
		tmer=1.0f;
		time = GetComponent<Text> ();	
	}
	void Update () 
	{
		
		tmer += Time.deltaTime;
		PlayerPrefs.SetFloat ("TotalTime",tmer);
		time.text = "" + tmer.ToString("F1");
	}
}
