using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

	public Transform player;
    public Transform obj1;

	public Transform door1;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position, obj1.position) <= 6f)
		{
			
		}
	}
}
