using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
	public Rigidbody2D birdGravity;
	public float flapStrength = 10;
	public LogicScript logic;
	public bool birdAlive = true;

	// Start is called before the first frame update
	void Start()
	{
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Space) && birdAlive) // If user holds down space key
		{
			birdGravity.velocity = Vector2.up * flapStrength; // Bird flies upwards
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		logic.GameOver();
		birdAlive = false;
	}

	//Richard was here
	//Ian was here too
}
