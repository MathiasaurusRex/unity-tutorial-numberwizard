using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {


	int max;
	int min;
	int guess;


	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame (){
		max = 1000;
		min = 1;
		guess = 500;
		print("===============================");
		print ("Welcome to number wizard");
		print ("Pick a number in your head but don't tell me.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick " + min);

		print ("Is the number higher or lower than " + guess +"?");
		print (" Up = higher, down = lower, enter = equals");

		max = max + 1;
	}

	void NextGuess (){
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess + "?");
			print (" Up = higher, down = lower, enter = equals");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			// print("Up arrow was pressed");
			min = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down arrow was pressed");
			max = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.Return)){
			print("I won");
			StartGame();
		}
	}
}
