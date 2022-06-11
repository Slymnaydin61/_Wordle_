 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class WordManager : MonoBehaviour
{
    public int reloadIndex=0;
    string [] words;
    string myWordFile,fileName;
    public int originIndex;
    public List<string> origin;
    public List<Button> keys;
    public int correctGuessCount;
    public List<TextMeshProUGUI> keyText;
    [SerializeField] string buttonText;
    char[] buttonChar;
    int buttonIndex;
    [SerializeField] Color[] buttonColors; 

    

    void Awake()
    {
        originIndex = PlayerPrefs.GetInt("index");
        fileName = "Wordle.txt";
        myWordFile = Application.dataPath + "/" + fileName;
        ReadFromFile(); 
        Debug.Log(origin[originIndex]);
        TurnString();
        TurnCharArray();

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
    public List<LetterState> GetStates(string msg)
    {
        var result = new List<LetterState>();
        

        List<char> listOrigin = origin[originIndex].ToCharArray().ToList();//Random word list
        string listMsg=msg.ToUpper();
        List<char> listCurrent = listMsg.ToCharArray().ToList();//Input list
        for (int i = 0; i < listCurrent.Count; i++ )
        {
            char currentChar = listCurrent[i];
            bool contains = listOrigin.Contains(currentChar);

            if( contains )
            {
                if (listCurrent[i] == listOrigin[i])
                {
                    result.Add((LetterState.Correct));
                    correctGuessCount++;
                    for(int j=0; j<buttonChar.Length; j++)
                    {
                        if (buttonChar[j] ==listCurrent[i])
                        {
                            keys[j].GetComponentInChildren<Image>().color = buttonColors[0];
                        }
                    }
                    Debug.Log("button index"+" "+buttonIndex);
                }
                else
                {
                    result.Add(LetterState.Contain);
                    for (int j = 0; j < buttonChar.Length; j++)
                    {
                        Color iscolored = keys[j].GetComponentInChildren<Image>().color;
                        if (buttonChar[j] == listCurrent[i] && iscolored != buttonColors[0])
                        {
                            keys[j].GetComponentInChildren<Image>().color = buttonColors[1];
                        }
                    }

                }
            }
            else
            {
                result.Add(LetterState.Failed);
                for (int j = 0; j < buttonChar.Length; j++)
                {
                    if (buttonChar[j] == listCurrent[i])
                    {
                        keys[j].GetComponentInChildren<Image>().color = buttonColors[2];
                    }
                }
            }
        }
        return result;
    }
}
