using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    public Text value;
    public GameObject[] gameButtons;
    public GameObject newGame;

    int min, max, guess;

    void Start()
    {
        NewGame();
    }

    public void GuessIsLower()
    {
        max = guess - 1;
        Guess();
    }

    public void GuessIsHigher()
    {
        min = guess + 1;
        Guess();
    }

    public void GuessMatches()
    {
        foreach (var button in gameButtons)
        {
            button.SetActive(false);
        }
        newGame.SetActive(true);
    }

    void Guess()
    {
        guess = (min + max) / 2;
        value.text = guess.ToString();
    }

    public void NewGame()
    {
        min = 1;
        max = 200;
        Guess();

        foreach (var button in gameButtons)
        {
            button.SetActive(true);
        }
        newGame.SetActive(false);
    }
}
