using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	PlayerManager playerManager;
	ButtonTrigger button;
	YouWonButtonTrigger youWonButtonTrigger;
	LifePointText LifePoints;
	public int life = 100;
	public int speed = 6;
	public bool respawn = false;
	public int damage = 25;


	// Use this for initialization
	void Start ()
	{
		playerManager = GameObject.Find ("Player").GetComponent <PlayerManager> ();
		playerManager.Init (life, speed, respawn);
		LifePoints = GameObject.Find ("LifePoints").GetComponent <LifePointText> ();
		BombTrigger[] triggers = FindObjectsOfType <BombTrigger> ();
		DoorTrigger[] doorTriggers = FindObjectsOfType<DoorTrigger> ();
		button = GameObject.Find ("Canvas").GetComponentInChildren <ButtonTrigger> ();
		button.Init ();
		youWonButtonTrigger = GameObject.Find ("Canvas").GetComponentInChildren <YouWonButtonTrigger> ();
		youWonButtonTrigger.Init ();


		foreach (DoorTrigger door in doorTriggers) {
			door.Init (button);
		}
			
		foreach (BombTrigger trigger in triggers) {

			trigger.OnTriggerBomb += handleOnTriggerBomb;

		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		LifePoints.textShow ("Your Lifepoints: " + playerManager.getLifePoints ());  
		playerManager.respawnThePlayer ();
	}

	void handleOnTriggerBomb ()
	{

		damageByEnterTheBomb (damage);

	}

	public void FinishedRespawn ()
	{

		youWonButtonTrigger.setButtonActive ();
		StartCoroutine (WonAfterFiveSeconds ());

	}

	IEnumerator WonAfterFiveSeconds ()
	{
		yield return new WaitForSeconds (5);
		Application.LoadLevel ("StartScene");

	}


	public void damageByEnterTheBomb (int damage)
	{
		playerManager.damagePlayer (damage);

	}
}


