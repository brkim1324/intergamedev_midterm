﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseControl : MonoBehaviour
{

	//public Transform Player;

	public Transform mysphere;
	public Transform Player;
	public float speed = 4.0f;
	private Rigidbody rd;
	public Vector3 jump;
	public float jumpForce;
	public GameObject bullet;

	//Death Targets
	public GameObject car;
	
	//public Transform gunEnd; (gunEnd)

	// Use this for initialization
	void Start()
	{
		rd = Player.GetComponent<Rigidbody>();
		jump = new Vector3(0f, 5f, 0f);
		//Vector3 spawnPos = new Vector3(); (gunend)
	}

	// Update is called once per frame
	void Update()
	{
		//Define Rays
		Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		Ray groundRay = new Ray(transform.position, Vector3.down);
		
		
		//RayDistance
		float mouseDistance = Mathf.Infinity;
		
		float groundDistance = 5.0f;
		float playerSpeed = speed * Time.deltaTime;
		
		
		
		//RaycastHit
		RaycastHit mouseRayHit = new RaycastHit();
		
		//Visualize Rays
		Debug.DrawRay(mouseRay.origin, mouseRay.direction * mouseDistance);
		Debug.DrawRay(groundRay.origin, groundRay.direction * groundDistance, Color.cyan);
		

		//Casting Rays
		if (Physics.Raycast(mouseRay, out mouseRayHit, mouseDistance))
		{
			mysphere.position = mouseRayHit.point;
			if (Input.GetMouseButton(1))
			{
				Player.transform.position =
					Vector3.MoveTowards(Player.transform.position, mouseRayHit.point, playerSpeed);
				//Instantiate(mysphere, mouseRayHit.point, Quaternion.Euler(0f, 0f, 0f));
			}

			if (Input.GetMouseButton(0))
			{
				//Instantiate(bullet, spawnPos)
			}
				

		}

		if (Physics.Raycast(groundRay, groundDistance))
		{
			//Debug.Log("ground is true");
		}
		
		

		//Hold down SPACE to Boost
		if (Input.GetKeyDown(KeyCode.Space))
		{
			speed += 6;
		}

		//Let go of SPACE to unBoost	
		if (Input.GetKeyUp(KeyCode.Space))
		{
			speed -= 6;
		}

		
		

	}

	public void Boost()
	{
		
	}
}
