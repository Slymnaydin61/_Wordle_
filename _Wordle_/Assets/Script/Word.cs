using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Word : MonoBehaviour
{
    [SerializeField] int fivechar;
    [SerializeField] int index;
    [SerializeField] string words;
    string originWord;
    [SerializeField] List<string> wordsList;
    [SerializeField] List<string> wordFile;
    [SerializeField] char[] charFile;
    int wordIndex;
    string myWorldFile;
    private void Awake()
    {
        FindFile();
        FindAllChar();
        FindAllChar();
        TurnWordToChar();
        TurnCharToFiveCharWords();

    }
    void Update()
    {
        AddWordToList();
    }
    void FindFile()
    {
        string fileName = "Wordle2.txt";
        myWorldFile= Application.dataPath + "/" + fileName;
    }

    void FindAllChar()
    {
        words=File.ReadAllText(myWorldFile).ToString();
    }
    
    void TurnWordToChar()
    {
        charFile = words.ToCharArray();
    }
    void TurnCharToFiveCharWords()
    {
      foreach(var letter in charFile)
        {
            wordFile.Add(letter.ToString());
        }
    }
    void AddWordToList()
    {
        int i = 0;
        if (i < wordFile.Count)
        {
            if (fivechar < index * 5)
            {
                originWord += wordFile[fivechar];
                wordFile.Remove(wordFile[fivechar]);
                fivechar++;
                if (fivechar == index * 5)
                {
                    wordsList.Add(originWord);
                    fivechar = 0;
                    originWord = "";
                }
            }

        }
    }

}
