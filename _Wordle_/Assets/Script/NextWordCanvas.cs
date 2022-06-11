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
    [SerializeField] GameObject helpCanvas;
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
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene1");
    }
    public void OpenHelpCanvas()
    {
        helpCanvas.SetActive(true);
    }
    public void CloseHelpCanvas()
    {
        helpCanvas.SetActive(false);
    }


  


}
