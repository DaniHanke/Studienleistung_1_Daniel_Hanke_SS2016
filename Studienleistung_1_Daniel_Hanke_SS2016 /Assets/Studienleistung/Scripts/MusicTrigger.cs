using UnityEngine;
using System.Collections;

public class MusicTrigger : MonoBehaviour
{

	AudioSource audiosource;

	public void Audio (bool onOrOff)
	{
		audiosource = GetComponent<AudioSource> ();
		if (onOrOff == true) {
			audiosource.Play ();
		} else {
			audiosource.Stop ();
		}
	}

}
