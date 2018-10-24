using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


	public float force;

	public Rigidbody rd;

	public float health;
	public Vector3 jump;
	public float jumpForce = 1f;
	private bool jumping = false;

	
	
	// Use this for initialization
	void Start ()
	{
		rd = GetComponent<Rigidbody>();
		jump = new Vector3(0f, 5f, 0f);
		


	}
	
	// Update is called once per frame
	void Update () {
		
		Ray grounded = new Ray(transform.position, Vector3.down);
		Ray aimRay = new Ray(transform.position, Input.mousePosition);

		float maxGroundDistance = 1.3f;
		Debug.DrawRay(grounded.origin, grounded.direction * maxGroundDistance, Color.cyan);

		float maxAimDistance = Mathf.Infinity;
		Debug.DrawRay(aimRay.origin, aimRay.direction * maxAimDistance, Color.green);
		
		RaycastHit mouseRayHit = new RaycastHit();
		
		

		if (Physics.Raycast(grounded, maxGroundDistance))
		{
			jumping = true;
		}
		
		if (Physics.Raycast(aimRay, out mouseRayHit, maxAimDistance))
		{
			
		}
		

		//if (jumping = true)
		//{
			//if (Input.GetKeyDown(KeyCode.Space))
			//{
				//rd.AddForce(jump * jumpForce, ForceMode.Impulse);
			//}
		//}

	}

	public void Jump()
	{
		jumping = true;
		

	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Death")
		{
			Respawn();
		}
	}

	void Respawn()
	{
		transform.position = Vector3.zero;
	}
}
