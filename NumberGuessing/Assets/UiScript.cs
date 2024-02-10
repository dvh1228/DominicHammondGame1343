using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class UiScript : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField Input;
    public Button submitButton;
    public Button resetButton;
    private int num1;
    private int attempts;
    public int guess;
    public string wantedInput;

    // Start is called before the first frame update
    void Start() 
    {
          GameSetup();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void GameSetup() 
    {

        header.text = "I am thinking of a number between 1 & 10. Can you guess it in 3 tries? ";

        num1 = UnityEngine.Random.Range(1, 11);

        attempts = 3;

        Input.text = "";

        Input.interactable = true;
        submitButton.interactable = true;
        resetButton.interactable = false;
    }

    public void Submission()
    {

        wantedInput = Input.text;
        int guess = int.Parse(wantedInput);

        if (guess >= 1 && guess <= 10)
        {

            if (guess != num1)
            {
                attempts--;

                if (attempts > 0)
                {
                    header.text = "Wrong try again you have " + attempts + " attempts left.";

                    Input.text = "";
                }
                else
                {
                    header.text = "You have run out of attempts the number was " + num1;
                    

                    Input.interactable = false;
                    submitButton.interactable = false;
                    resetButton.interactable = true;
                }
            }
            else
            {
                header.text = "Congratulations you guessed the right number";

                Input.interactable = false;
                submitButton.interactable = false;
                resetButton.interactable = true;
            }

        }
    }
    public void ResetGame()
    {
        GameSetup();
    }
}
