using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] WordManager wordManager;
    [SerializeField] GameObject helpCanvas;
    public void PlayGame()
    {
        wordManager.originIndex = Random.Range(0, wordManager.origin.Count);
        PlayerPrefs.SetInt("index", wordManager.originIndex);
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
