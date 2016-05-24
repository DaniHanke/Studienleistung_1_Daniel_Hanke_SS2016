using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeShown : MonoBehaviour
{
	private Text time;


	// Use this for initialization
	void Start ()
	{
		time = gameObject.GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		time.text = "Time: " + Time.time;

	}
}
