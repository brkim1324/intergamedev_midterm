using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

	public Rigidbody rd;

	public float speed = 10f;
	// Use this for initialization
	void Start ()
	{
		rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Ray carRay = new Ray(transform.position, transform.forward);

		float maxDistance = 100.0f;
		
		Debug.DrawRay(carRay.origin, carRay.direction*maxDistance, Color.green);

		if (Physics.Raycast(carRay, maxDistance))
		{
			transform.Translate(0f,0f,Time.deltaTime * speed);
		}
		
		
		
		
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Wall")
		{
			Destroy(gameObject);
		}
	}
}
