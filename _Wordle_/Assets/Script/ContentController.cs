using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class ContentController : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] Button temp;
    [SerializeField] List<RowController> rows;

    [SerializeField] WordManager wordManager;

    public int guesscount;
    public int _index;
    void Start()
    {
        inputField.onValueChanged.AddListener(OnUpdateContent);
    }
    void OnUpdateContent(string msg)
    {
        var row = rows[_index];
        row.UpdateText(msg);
    }
    void UpdateState()
    {
        var states = wordManager.GetStates(inputField.text);
        rows[_index].UpdateState(states);
    }
    public void OnSubmit(LetterState state)
    {
        if(wordManager.isExist)
        {
            temp.Select();
            inputField.Select();
            if (!IsEnough())
            {
                return;

            }
            else if (_index > 5)
            {
                return;
            }
            UpdateState();
            guesscount++;
            _index++;
            inputField.text = "";
        }
        else
        {
            Debug.Log("Böyle Bir Kelime Yok");
        }
        wordManager.isExist = false;
    }
    private bool IsEnough()
    {
        return inputField.text.Length == rows[_index].blockCount;
    }
}
