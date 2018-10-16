using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{

	public Transform player;

	public Transform door;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position, door.position) <= 10f)
		{
			transform.Translate(Vector3.up * Time.deltaTime);
		}
	}
}
