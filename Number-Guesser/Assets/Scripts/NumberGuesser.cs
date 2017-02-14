using UnityEngine;
using System.Collections;

public class NumberGuesser : MonoBehaviour 
{
	//Declaring Variables
	int maxNum;
	int minNum;
	int guessNum;

	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			minNum = guessNum;
			NextGuess();
		}

		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			maxNum = guessNum;
			NextGuess();
		}

		else if(Input.GetKeyDown(KeyCode.Return))
		{
			print("I won!");
			StartGame();
		}

	}

	void StartGame()
	{
		//Initilizing Variables
		maxNum = 1000;
		minNum = 1;
		guessNum = 500;
	
		print ("============================");
		print ("Welcome to number Guesser");
		print ("Pick a number in your head but don't tell me");
		print ("The highest number you can pick is: " + maxNum);
		print ("The lowest number you can pick is: " + minNum);
		
		print ("Is the number higher or lower than " + guessNum + "?");
		print ("Up = Higher, Down = Lower, Return = Equal");

		maxNum = maxNum + 1;
	}

	void NextGuess()
	{
		guessNum = (maxNum + minNum) / 2;
		print ("Higher or lower than " + guessNum + "?");
		print ("Up = Higher, Down = Lower, Return = Equal");
	}
}
