﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour
{
	public Text myText;
	public Transform obj1;
	
	public Transform player;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position, obj1.position) <= 6f)
		{
			myText.text = "Proceed";
		}
		
			
		
	}
}
