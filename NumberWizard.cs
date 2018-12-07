using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

   public int maxGuessesAllowed = 10;

    public Text text;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame () {
        max = 1000;
        min = 1;
        NextGuess();


        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + "?");
        print("Press the up arrow for higher, down arrow for lower, and enter for equals.");
    }
	

    public void GuessLower () {
        max = guess;
        NextGuess();
}

    public void GuessHigher () {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range (min, max + 1);
        text.text = guess.ToString();
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if (maxGuessesAllowed <= 0){
            SceneManager.LoadScene("Win");
        }

    }
}
