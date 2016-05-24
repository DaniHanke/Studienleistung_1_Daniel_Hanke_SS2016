using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonTrigger : MonoBehaviour
{

	private Button button;

	public void Init ()
	{
		button = GetComponent<Button> ();
		gameObject.SetActive (false);

	}

	public void setEvent (UnityAction action)
	{
		button.onClick.RemoveAllListeners ();
		button.onClick.AddListener (action);
	}

	public void setButtonActive ()
	{
		
		gameObject.SetActive (true);

	}

	public void setButtonDeactive ()
	{
		
		gameObject.SetActive (false);
	}
		

}
