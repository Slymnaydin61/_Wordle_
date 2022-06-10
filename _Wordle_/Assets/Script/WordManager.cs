 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using TMPro;

public class WordManager : MonoBehaviour
{
    string [] words;
    string myWordFile,fileName;
    int originIndex;
    [SerializeField] List<string> origin;

    void Start()
    {  
        fileName = "Wordle.txt";
        myWordFile = Application.dataPath + "/" + fileName;
        ReadFromFile();
        originIndex =Random.Range(0, origin.Count);
        Debug.Log(origin[originIndex]);
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

    public List<State> GetStates(string msg)
    {
        var result = new List<State>();

        var listOrigin = origin[originIndex].ToCharArray().ToList();
        var listMsg=msg.ToUpper();
        var listCurrent = listMsg.ToCharArray().ToList();
        for (int i = 0; i < listCurrent.Count; i++ )
        {
            char currentChar = listCurrent[i];
            
            Debug.Log(listCurrent[i]);
            bool contains = listOrigin.Contains(currentChar);
            Debug.Log(contains);
            if( contains )
            {
                var index =listOrigin.FindIndex(x => x == currentChar);
                var isCorrect = index == i;    
                result.Add(isCorrect ? State.Correct : State.Contain);
                
            
            }
            else
            {
                result.Add(State.Failed);
            }
        }
        return result;
    }
}
