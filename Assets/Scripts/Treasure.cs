using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Treasure : MonoBehaviour
{
	public Text uiText;
	public Transform player;
	public Transform treasure;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position, treasure.position) <= 5f)
		{
			uiText.text = "My Crown!";
			uiText.text += "\nPRESS SPACEBAR TO RECLAIM YOUR CROWN!";
		
			Crown();
			
		}
	}

	public void Crown()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			uiText.text = "I am now worthy again!";
			
			uiText.text += "\nYOU WIN!";
		}
	}
}
