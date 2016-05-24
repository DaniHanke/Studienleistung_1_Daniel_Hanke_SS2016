using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour
{

	GameManager gameManager;


	void OnCollisionEnter (Collision col)
	{
		gameManager.FinishedRespawn ();
	}

	void Start ()
	{
		gameManager = GameObject.Find ("GameManager").GetComponent <GameManager> ();
	}

}
