using UnityEngine;
using System.Collections;

public class PlayerInputManager : MonoBehaviour
{

	public int speed;
	public int rotationSpeed;
	public Rigidbody rb;
	public bool respawn;
	private string m_MovementAxisName;
	private string m_TurnAxisName;
	private float m_MovementInputValue;
	private float m_inputRotation;
	private float m_MovementInputValueBackwards;
	private float m_TurnInputValue;


	// Use this for initialization
	void Start ()
	{
		settingComponents ();
		Init ();
	}

	private void FixedUpdate ()
	{
		movingThePlayer ();
		turningThePlayer ();
	}


	public void setPlayerByRespawn ()
	{
		Application.LoadLevel ("StartScene");
	}


	void settingComponents ()
	{
		m_MovementInputValue = 0f;
		m_TurnInputValue = 0f;
		rotationSpeed = 4;
		speed = 3;
	}


	void movingThePlayer ()
	{

		m_MovementInputValue = Input.GetAxis (m_MovementAxisName);
		m_MovementInputValueBackwards = Input.GetAxis (m_MovementAxisName);

		Vector3 movement = transform.forward * speed * m_MovementInputValue * 3 * Time.deltaTime;
		Vector3 movementBackward = transform.forward * m_MovementInputValueBackwards * speed * 3 * Time.deltaTime;


		// moving forward
		if (Input.GetKey (KeyCode.W)) {
			rb.MovePosition (rb.position + movement);

		}

		// moving backwards
		if (Input.GetKey (KeyCode.S)) {

			rb.MovePosition (rb.position + movementBackward);

		}
			
	}


	void turningThePlayer ()
	{
		
		// turn left
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up * rotationSpeed);


		}

		// turn right
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.down * rotationSpeed);
		}	

	}


	public void Init ()
	{

		m_MovementAxisName = "Vertical";
		m_TurnAxisName = "Horizontal";

		rb = GetComponent <Rigidbody> ();

	}

}
