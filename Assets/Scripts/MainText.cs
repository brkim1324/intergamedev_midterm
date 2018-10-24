using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainText : MonoBehaviour
{
	public Text myText;
	public Transform obj1;
	public Transform obj2;
	public Transform obj3;
	public Transform ending;
	
	public Transform player;
	
	// Use this for initialization
	void Start ()
	{
		myText.text = "Finish the course!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.position, obj1.position) <= 6f)
		{
			myText.text = "Proceed";
		}
		
		if (Vector3.Distance(player.position, obj2.position) <= 6f)
		{
			myText.text = "Proceed";
		}
		
		if (Vector3.Distance(player.position, obj3.position) <= 6f)
		{
			myText.text = "Proceed";
		}

		if (Vector3.Distance(player.position, ending.position) <= 8f)
		{
			myText.text = "CONGRATULATIONS!";
		}
		
			
		
	}
}
