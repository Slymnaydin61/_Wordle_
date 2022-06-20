using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JokerButton : MonoBehaviour
{
    WordManager wordManager;
    [SerializeField] List<char> wordChar;
    [SerializeField] List<Button> keyboard;
    [SerializeField] List<Image> myButtonImages;
    char[] word;
    [SerializeField] string cuurentWord;


    void Awake()
    {
        wordManager=FindObjectOfType<WordManager>();


    }
    void Update()
    {
        FindCurrentWord();
        TurnWordToArrayChar();
        Debug.Log(cuurentWord);
    }
    void FindCurrentWord()
    {

        cuurentWord = wordManager.origin[wordManager.originIndex];
        word = cuurentWord.ToCharArray();
    }
    void TurnWordToArrayChar()
    {  
        if(wordChar.Count <5)
        {
            foreach (var letter in word)
            {
                wordChar.Add(letter);
            }
        }
    }

    public void GiveJokerLetter()
    {
       foreach( var item in wordManager.buttonChar)
       {
            for(int i = 0; i < wordChar.Count; i++)
            {
                if(item==wordChar[i])
                {
                    //myButtonImages.Add()
                }
            }
       }
    }
}
