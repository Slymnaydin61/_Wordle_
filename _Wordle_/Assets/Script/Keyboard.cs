using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    GameManager gameManager;
    WordManager wordManager;


    [SerializeField] TMP_InputField inputField;


    public List<Color> stateColor;

    public bool isColored;
    public bool canCount;
    void Awake()
    {
        wordManager=FindObjectOfType<WordManager>();
        gameManager=FindObjectOfType<GameManager>();
        
    }
    public void InputLetter(string letter)
    {
        int inputAmount = inputField.text.Length;
        int correctGuessAmount = wordManager.correctGuessCount;
        if(inputAmount<5 && correctGuessAmount<5 )
        {
            inputField.text = inputField.text + "" + letter.ToCharArray()[0];
        }
    }
    public void DeleteLetter()
    {
        int i = inputField.text.Length;
        var input = inputField.text.ToCharArray();

        if (inputField.text.Length>0)
        {
            inputField.text = null;
            input[i-1] = ' ';
            for (int j = 0; j < input.Length-1; j++)
            {
                inputField.text = inputField.text + input[j];
            }
        }
        
    }
    public void CheckLetter(ContentController contentController)
    {
        wordManager.correctGuessCount = 0;
        canCount = true;
        contentController.OnSubmit(LetterState.Contain);
        gameManager.canvasTimer = 2f;
    }
   
   
}
