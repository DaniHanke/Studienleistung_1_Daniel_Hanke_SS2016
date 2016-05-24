using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

	private bool isOpen;
	
	// Update is called once per frame
	void Update ()
	{
	
		OpenDoorIfBoolIsTrue ();
		CloseDoorIfBoolIsFalse ();

	}

	void OpenDoorIfBoolIsTrue ()
	{

		if (isOpen) {	
			Vector3 position = gameObject.transform.position;
			position.y = -1;
			transform.position = Vector3.MoveTowards (transform.position, position, Time.deltaTime);
		}
	}

	public void Open (bool doorStatus)
	{

		isOpen = doorStatus;

	}

	public void CloseDoorIfBoolIsFalse ()
	{
		if (isOpen == false) {
			
			Vector3 position = gameObject.transform.position;
			position.y = 3;
			transform.position = Vector3.MoveTowards (transform.position, position, Time.deltaTime);

		}

	}

}
