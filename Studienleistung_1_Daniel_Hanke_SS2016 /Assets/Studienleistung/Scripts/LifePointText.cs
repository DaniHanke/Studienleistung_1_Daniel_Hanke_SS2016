using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifePointText : MonoBehaviour
{

	private Text lifePoints;

	// Use this for initialization
	void Start ()
	{
		lifePoints = GetComponent <Text> ();
	}


	public void textShow (string text)
	{

		lifePoints.text = text;
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
