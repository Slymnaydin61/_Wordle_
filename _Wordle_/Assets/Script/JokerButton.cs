using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JokerButton : MonoBehaviour
{
    WordManager wordManager;
    ContentController contentController;
    [SerializeField] List<RowController> rowController;
    [SerializeField] List<char> wordChar;
    [SerializeField] List<Button> keyboard;
    [SerializeField] List<Button> wordsButton;
    [SerializeField] string cuurentWord;
    [SerializeField] int jokerCount=3;
    char[] word;
    int listCount;
    int index;
    float showTimer;
    bool isHintGiven;
  


    void Awake()
    {
        contentController = FindObjectOfType<ContentController>();
        wordManager=FindObjectOfType<WordManager>();
    }
    void Update()
    {
        FindCurrentWord();
        TurnWordToArrayChar();
        ButtonToList();
       // DeleteJokerLetter();
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
    void ButtonToList()
    {
        foreach (var button in keyboard)
        {
            for(int i=0; i<wordChar.Count; i++)
            {
                if (button.name == wordChar[i].ToString()&&listCount<5)
                {
                    wordsButton.Add(button);
                    listCount++;
                }
            }
        }
    }
    void DeleteJokerLetter()
    {
        showTimer -= Time.deltaTime;
        if(showTimer<0&&isHintGiven)
        {
            rowController[contentController._index].blocks[index].UpdateText(' ');
        }
    }

    public void GiveJokerLetter()
    {
        if(jokerCount>0)
        {
            RandomizeHintLetter();
            ColorKeyBoard();
            showTimer = 2f;
            isHintGiven = true;
            jokerCount--;
        }
    }
    void RandomizeHintLetter()
    {
        index = Random.Range(0, wordsButton.Count);
        for(int i=0; i<wordChar.Count;i++)
        {
            if (wordsButton[index].name == wordChar[i].ToString())
            {
                rowController[contentController._index].blocks[i].UpdateText(wordChar[i]);
            }
        }
    }
    void ColorKeyBoard()
    {
        wordsButton[index].GetComponentInChildren<Image>().color = wordManager.buttonColors[0];
    }
}
