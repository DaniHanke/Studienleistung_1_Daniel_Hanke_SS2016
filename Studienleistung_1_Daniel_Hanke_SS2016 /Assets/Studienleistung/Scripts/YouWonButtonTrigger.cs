using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class YouWonButtonTrigger : MonoBehaviour
{
	private Button button;


	// Use this for initialization
	public void Init ()
	{
		button = GetComponent<Button> ();
		gameObject.SetActive (false);

	}

	public void setButtonActive ()
	{
		gameObject.SetActive (true);
	}

}
