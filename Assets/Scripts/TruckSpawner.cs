﻿using UnityEngine;
using System.Collections;

public class TruckSpawner : MonoBehaviour {

	public string whichRedPrefab;
	public string whichYellowPrefab;
	public float timer = 10f;
	public float repeat = 10f; 
	public int carsPerLevel;
	public Transform[] spawnPoints;
	private int spawnPointIndex;
	private int randomCar = 0;
	private int next = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		
		if (timer <= 0 && next <= carsPerLevel && randomCar == 0) {
			string car = next.ToString();
			randomCar = Random.Range (0,2);
			spawnPointIndex = Random.Range (0,spawnPoints.Length);
			GameObject go = Instantiate (Resources.Load (whichYellowPrefab), spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
			go.tag = "Truck" + car;
			Debug.Log ("Truck" + car);
			go.GetComponent<Car1>().carTag = "Truck" + car;
			timer = repeat;
			next++;
		} else if (timer <= 0 && next <= carsPerLevel && randomCar == 1) {
			string car = next.ToString();
			randomCar = Random.Range (0,2);
			spawnPointIndex = Random.Range (0,spawnPoints.Length);
			GameObject go = Instantiate (Resources.Load (whichRedPrefab), spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation) as GameObject;
			go.tag = "Truck" + car;
			Debug.Log ("Truck" + car);
			go.GetComponent<Car1>().carTag = "Truck" + car;
			timer = repeat;
			next++;
		}
	}
}
