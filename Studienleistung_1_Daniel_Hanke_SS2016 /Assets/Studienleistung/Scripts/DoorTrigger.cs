using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor;
using UnityEngine.Events;

public class DoorTrigger : MonoBehaviour
{

	public Door door;
	private GameObject canvas;
	private MusicTrigger tetris;
	private ButtonTrigger button;
	private UnityAction action;

	public void Init (ButtonTrigger button)
	{
		this.button = button;
		tetris = GameObject.Find ("Audio Source").GetComponent <MusicTrigger> ();
		action = new UnityAction (openDoor);
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("COLLISION");
		tetris.Audio (true);

		button.setButtonActive ();
		StartCoroutine (Example ());
		button.setEvent (openDoor);
	}

	void OnTriggerExit (Collider other)
	{
		tetris.Audio (false);

		button.setButtonDeactive ();
	}

	IEnumerator Example ()
	{
		yield return new WaitForSeconds (40);
		door.Open (false);


	}

	public void openDoor ()
	{
		door.Open (true);
	}


}
