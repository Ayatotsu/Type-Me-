using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WordTyper : MonoBehaviour
{
    public Timer timer;
    
    public WordList wordList = null;
    public TextMeshProUGUI wordOutput = null;
    public AudioSource keytaps;

    private string wordRemaining = string.Empty;
    private string currentWord = string.Empty;
    


    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    // Update is called once per frame
    private void Update()
    {
        InputChecker();
    }


    private void SetCurrentWord() 
    {
        currentWord = wordList.GetWord();
        SetRamainingWord(currentWord);
    }

    private void SetRamainingWord(string newWord) 
    {
        wordRemaining = newWord;
        wordOutput.text = wordRemaining;
    }

    private void InputChecker() 
    {
        if (Input.anyKeyDown) 
        {
            string keyPressed = Input.inputString;

            if (keyPressed.Length == 1)
            {
                InputLetter(keyPressed);
            }
        }
    }

    private void InputLetter(string inputLetter) 
    {
        if (IsCorrectInput(inputLetter)) 
        {
            RemoveInput();

            if (IsWordPressed()) 
            {
                timer.totalScore += 5;
                SetCurrentWord();
            }
        }
    }

    private bool IsCorrectInput(string letter) 
    {
        return wordRemaining.IndexOf(letter) == 0;
    }

    private void RemoveInput() 
    {
        string newString = wordRemaining.Remove(0, 1);
        SetRamainingWord(newString);
    }

    private bool IsWordPressed() 
    {
        keytaps.Play();
        return wordRemaining.Length == 0;
    }
}
