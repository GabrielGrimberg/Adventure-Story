using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberGuesser : MonoBehaviour 
{

	public Text guessText;

	int max = 1000;
	int min = 1;
	int guess;
	public int  maxGuessesAllowed = 5;

	public Text text;

	void Start() 
	{
		StartGame();
	}

	void StartGame() 
	{
		max = 1000;
		min = 1;
		NextGuess();

		max = max + 1;
	}

	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}

	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}

	public void GuessCorrect()
	{
		StartGame();
	}

	void NextGuess() 
	{
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;

		if(maxGuessesAllowed <= 0)
		{
			Application.LoadLevel("Win");
		}
	}
}