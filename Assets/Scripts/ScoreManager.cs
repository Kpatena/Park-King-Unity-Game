﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	public static int initialScore;
	
	private Text scoreText;
	
	void Start(){

		scoreText = GetComponent<Text>();

		initialScore = 0;

	}
	
	void Update(){

		if (initialScore < 0) {

			initialScore = 0;

		}

		scoreText.text = "" + initialScore;

	}
	
	public static void addPoints(int addPoint){

		initialScore += addPoint;

	}
	
	public static void decreasePoints(){

		initialScore -= 100;

	}
}