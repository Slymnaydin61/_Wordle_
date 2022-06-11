using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextWordCanvas : MonoBehaviour
{
    [SerializeField] List<BlockController> blocks;
    [SerializeField] List<Animator>  blocksAnimator;
    ContentController contentController;
    RowController rowController;
    WordManager wordManager;

    [SerializeField] GameObject canvas;
    [SerializeField] List<RowController> rows;

    void Awake()
    {
        //foreach (var block in blocks)
        //{
        //    blocksAnimator = FindObjectOfType<Animator>();
        //}
        rowController = FindObjectOfType<RowController>();
        contentController=FindObjectOfType<ContentController>();
        wordManager=FindObjectOfType<WordManager>();
    }
    public void SceneLoad()
    {
        wordManager.originIndex=Random.Range(0,wordManager.origin.Count);
        PlayerPrefs.SetInt("index", wordManager.originIndex);
        SceneManager.LoadScene("GameScene2");
        
    }
    public void SceneLoad2()
    {
        wordManager.originIndex = Random.Range(0, wordManager.origin.Count);
        PlayerPrefs.SetInt("index", wordManager.originIndex);
        SceneManager.LoadScene("GameScene1");
    }
    public void WronGuess()
    {
        PlayerPrefs.SetInt("index", wordManager.originIndex);
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

    //public void NextWord()
    //{

    //    contentController._index = 0;
    //    wordManager.guessCount = 0;
    //    wordManager.originIndex=Random.Range(0,wordManager.origin.Count);
    //    var row = rows[contentController._index];
    //    for(int i=0; i<blocks.Count; i++)
    //    {
    //        blocksAnimator[i].SetInteger("State", 3);

    //    }

    //    Invoke("CloseCanvas", 2.5f);
    //    Debug.Log(wordManager.origin);
    //} 

    //void CloseCanvas()
    //{
    //    canvas.SetActive(false);
    //}


}
