using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows us to do UI stuff

public class NumberGenerator : MonoBehaviour
{
    //set up the variables first
    public Text answer;
    public InputField answerGiven;

    private int numberToGuess;

    // Start is called before the first frame update
    void Start()
    {
        numberToGuess = Random.Range(0, 100); //At the start, assign a number between 0 and 100 to the variable
    }

    public void CheckAnswer() //create a function which will check the answer given.
    {
        //set up variables for this function
        int enteredAnswer;
        string answerGivenString;

        //Grab the text entered and converts it to a string variable
        answerGivenString = answerGiven.text;

        //convert the variable to a number (whole number = int)
        int.TryParse(answerGivenString, out enteredAnswer);

        //check to see if answers are correct
        if(enteredAnswer == numberToGuess) //this will run if the number is guessed exactly. == means is equal to
        {
            answer.text = "You win!";
        }
        if(enteredAnswer > numberToGuess) //this will run if the number guessed is higher than the actual value
        {
            answer.text = "Try lower";
        }
        if(enteredAnswer < numberToGuess) //this will run if the number guessed is lower than the actual value
        {
            answer.text = "Try higher";
        }

    }
}
