using UnityEngine;
using System.Collections;

public delegate void TriggerBomb ();

public class BombTrigger : MonoBehaviour
{

	public event TriggerBomb OnTriggerBomb;


	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider other)
	{
		Explode ();

		if (OnTriggerBomb != null) {
			OnTriggerBomb ();
		}
	}


	void Explode ()
	{
		ParticleSystem explosionEffect = GetComponent<ParticleSystem> ();
		explosionEffect.Play ();

		StartCoroutine (DestroyAfterFewSeconds ());

	}

	IEnumerator DestroyAfterFewSeconds ()
	{

		yield return new WaitForSeconds (2);

		Destroy (gameObject);

	}
}
