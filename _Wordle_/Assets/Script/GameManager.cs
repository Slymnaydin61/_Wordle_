using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Keyboard keyboard;
    ContentController contentController;
    WordManager wordManager;


    [SerializeField] GameObject nextWordCanvas;
    [SerializeField] GameObject wrongGuessCanvas;


    [SerializeField] float delayTime=2;
    public float canvasTimer;

    void Awake()
    {
        contentController=FindObjectOfType<ContentController>();
        keyboard=FindObjectOfType<Keyboard>();
        wordManager = FindObjectOfType<WordManager>();
    }
    void Update()
    {
        LetCountDown();
        StartOpenCanvas();
        SetCanCount();
        OpenWrongGuessCanvas();
    }
 
    void StartOpenCanvas()
    {
        if(canvasTimer<=0)
        {
            OpenCanvas();
        }
    }

    void SetCanCount()
    {
        if (wordManager.correctGuessCount > 4)
        {
            keyboard.canCount = true;
        }
    }
    void OpenCanvas()
    {
        if(wordManager.correctGuessCount>4)
        {
            nextWordCanvas.SetActive(true);
        }
        
    }
    void LetCountDown()
    {
        if(keyboard.canCount)
        {
            CountDownForCanvas();
        }
    }
    void CountDownForCanvas()
    {
        canvasTimer -= Time.deltaTime;
    }
    void OpenWrongGuessCanvas()
    {
        if(contentController.guesscount > 5 && wordManager.correctGuessCount<5)
        {
            Invoke("DelayWrongGuessCanvas",delayTime);
        }
        
    }
    void DelayWrongGuessCanvas()
    {
        wrongGuessCanvas.SetActive(true);
    }
    
}
