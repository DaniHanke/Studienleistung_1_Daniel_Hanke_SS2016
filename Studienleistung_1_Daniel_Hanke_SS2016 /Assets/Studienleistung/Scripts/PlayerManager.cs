using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

	private PlayerInputManager playerInputManager;

	private int lifePoints;
	bool respawn;
	int speed;



	public void Init (int lifePoints, int speed, bool respawn)
	{
		this.speed = speed;
		this.lifePoints = lifePoints;
		this.respawn = respawn;

		playerInputManager = GameObject.Find ("Player").GetComponent <PlayerInputManager> ();
		playerInputManager.Init ();
	}

	public void damagePlayer (int damage)
	{
		lifePoints -= damage;

	}

	public void respawnThePlayer ()
	{
		if (lifePoints == 0) {

			playerInputManager.setPlayerByRespawn ();
		}

	}

	public int getLifePoints ()
	{
		return lifePoints;

	}


		
}
