using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{

	public Transform player;
	public Vector3 offset;
	public Space offsetPosSpace = Space.Self;
	private bool lookAt = true;
		
	
	// put this script on your Main Camera, and make sure your Main Camera is already pointed down
	//declare a public variable of type Transform called "myPlayer"; // make sure to assign in Inspector

	//UPDATE:
	//// remember... to access the script's transform, write "transform" (with lowercase "t")
	//move this transform to myPlayer's position;
	//move this transform up 5 units on the Y axis;
	//move this transform back 5 units on the Z axis;
	// Use this for initialization
	void Start()
	{
		
	}

	void LateUpdate()
	{
		Refresh();
	}
	
	public void Refresh()
	{
		if (player == null)
		{
			Debug.LogWarning("Missing target ref !", this);

			return;
		}

		// compute position
		if (offsetPosSpace  == Space.Self)
		{
			transform.position = player.TransformPoint(offset);
		}
		else
		{
			transform.position = player.position + offset;
		}

		// compute rotation
		if (lookAt)
		{
			transform.LookAt(player);
		}
		else
		{
			transform.rotation = player.rotation;
		}
	
	// Update is called once per frame
	//void Update ()
	//{
		//transform.position = myPlayer.position;
		//transform.position += new Vector3(0f,1f,-5f);

		//if (Input.GetKey(KeyCode.A))
		//{
			//transform.Rotate(0,-5f,0f);
		//}
		//transform.position += new Vector3(0f,5f,-5f);
		//transform.Translate(0f,0f,-5f);

	}
}
