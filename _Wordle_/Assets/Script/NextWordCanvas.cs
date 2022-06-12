using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextWordCanvas : MonoBehaviour
{
    WordManager wordManager;

    void Awake()
    {
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

}
