using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

	public GameObject LineOne;
	public GameObject car;
	// Use this for initialization
	void Start () {
		int carCount = 0;

		while (carCount < 10)
		{
			Vector3 spawnPos = new Vector3(-8, 1f, Random.Range(-100,100f));
			Instantiate(car, spawnPos, Quaternion.Euler(5f, 5f, 5f));

			carCount++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
