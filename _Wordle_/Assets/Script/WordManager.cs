 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class WordManager : MonoBehaviour
{
    public int reloadIndex = 0;
    public int originIndex;
    public int correctGuessCount;

    int buttonIndex;
    int letterIndex;

    public List<string> origin;
    public List<Button> keys;
    List<char> listCurrent;

    string[] words;
    public char[] buttonChar;
    public Color[] buttonColors;

    public bool isExist;

    string myWordFile,fileName;

    [SerializeField] string buttonText;

    [SerializeField] TMP_InputField inputField;
    
    void Awake()
    {
        DefineIndex();
        FindWords();
        ReadFromFile(); 
        TurnString();
        TurnCharArray();
    }
    void Update()
    {
        CheckWordIsExist();
    }
    void FindWords()
    {
        fileName = "Wordle.txt";
        myWordFile = Application.dataPath + "/" + fileName;
    }
    void DefineIndex()
    {
        originIndex = PlayerPrefs.GetInt("index");
    }
    void TurnString()
    {
        foreach(var keys in keys)
        {
            buttonText = buttonText+keys.name;
        } 
    }
    void TurnCharArray()
    {
        buttonChar = buttonText.ToCharArray();
    }

    void ReadFromFile()
    {
        words=File.ReadAllLines(myWordFile);     
        foreach (string line in words)
        {
            line.ToUpper();
            origin.Add(line);   
        }
    }
    public void CheckWordIsExist()
    {
        string inputWord=inputField.text.ToString().ToUpper();
        Debug.Log(inputWord);
        foreach(var word in origin)
        {
            if (inputWord == word)
            {
                isExist = true;
                Debug.Log("Kelime Doðru");
            }     
        }
    }
    public List<LetterState> GetStates(string msg)
    {
        var result = new List<LetterState>();
        List<char> listOrigin = origin[originIndex].ToCharArray().ToList();//Random word list
        string listMsg = msg.ToUpper();
        listCurrent = listMsg.ToCharArray().ToList();//Input list
        for (letterIndex = 0; letterIndex < listCurrent.Count; letterIndex++)
        {
            char currentChar = listCurrent[letterIndex];
            bool contains = listOrigin.Contains(currentChar);
            if (contains)
            {
                if (listCurrent[letterIndex] == listOrigin[letterIndex])
                {
                    result.Add((LetterState.Correct));
                    correctGuessCount++;
                    ColorCorrectButton();

                }
                result.Add(LetterState.Contain);
                ColorExistButton();
            }
            else
            {
                result.Add(LetterState.Failed);
                ColorWrongGuessButton();
            }
        }
        return result;
    }
    void ColorWrongGuessButton()
    {
        for(buttonIndex=0;buttonIndex<buttonChar.Length;buttonIndex++)
        {
            if (buttonChar[buttonIndex] == listCurrent[letterIndex])
            {
                keys[buttonIndex].GetComponentInChildren<Image>().color = buttonColors[2]; ;
            }
        }
    }
    void ColorExistButton()
    {
        for ( buttonIndex = 0; buttonIndex < buttonChar.Length; buttonIndex++)
        {
            Color iscolored = keys[buttonIndex].GetComponentInChildren<Image>().color;
            if (buttonChar[buttonIndex] == listCurrent[letterIndex] && iscolored != buttonColors[0])
            {
                keys[buttonIndex].GetComponentInChildren<Image>().color = buttonColors[1];
            }
        }
    }
    void ColorCorrectButton()
    {
        for ( buttonIndex = 0; buttonIndex < buttonChar.Length; buttonIndex++)
        {
            if (buttonChar[buttonIndex] == listCurrent[letterIndex])
            {
                keys[buttonIndex].GetComponentInChildren<Image>().color = buttonColors[0];
                keys[buttonIndex].GetComponentInChildren<Keyboard>().isColored = true;
            }
        }
    }
        
}
