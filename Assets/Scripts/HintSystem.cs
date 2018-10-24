using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintSystem : MonoBehaviour
{
	public Text uiText;
	public Transform player;
	public Transform obj1;
	public Transform obj2;
	public Transform obj3;


	// Use this for initialization
	void Start()
	{
		uiText.text = "King Bear: 'Hmm... Where did I leave my crown?'";
		uiText.text += "\n'Maybe I left it by the TV?'";
		uiText.text += "\nGO STRAIGHT!";
	}

	// Update is called once per frame
	void Update()
	{


		if (Vector3.Distance(player.position, obj1.position) <= 6f)
		{
			uiText.text = "It's not here. Maybe it's by my Chicken?";
			uiText.text += "\nGO STRAIGHT!";
		}

		if (Vector2.Distance(player.position, obj2.position) <= 6f)
		{
			uiText.text = "It's not here either!";
			uiText.text += "\nBy my bed then?";
			uiText.text += "\nGO EAST!";

			if (Vector3.Distance(player.position, obj3.position) <= 6f)
			{
				uiText.text = "I remember now!";
				uiText.text += "\nGO EAST!";

			}


		}
	}
}
