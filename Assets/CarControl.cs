using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//usage: put this on a Cube with a Rigidbody
//intent: this will let you control a Car, kind of 
public class CarControl : MonoBehaviour
{
	private Rigidbody rd;
	private Vector2 inputVector;

	//Unity will use the value in Inspector, not from code 
	public float moveSpeed = 10f;
	public float turnSpeed = 90f;
	
	// Use this for initialization
	void Start ()
	{
		//cache reference to Rigidbody
		rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Input.GetAxis return a number between -1f and 1f... 0f if nothing
		//horizontal = A/D, left/right, Left=-1/Right=+1
		float horizontal = Input.GetAxis("Horizontal");
		//vertical = W/S on Keyboard, Up=+1/Down=-1
		float vertical = Input.GetAxis("Vertical");
		
		inputVector = new Vector2(horizontal, vertical);
		

	}

	//runs every physics frame (to change it, see Edit > project settings > time) 
	private void FixedUpdate()
	{
		//forward and backward thrust
		rd.AddForce(transform.forward * inputVector.y * moveSpeed);
		
		
		//left and right turning 
		rd.AddTorque(0f,inputVector.x * turnSpeed, 0f);
	}
}
