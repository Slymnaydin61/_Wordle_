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
    BlockController blockController;
    

    int _index;
    void Start()
    {
        blockController=FindObjectOfType<BlockController>();
        inputField.onValueChanged.AddListener(OnUpdateContent);
        inputField.onSubmit.AddListener(OnSubmit);
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
    void OnSubmit(string msg)
    {
        blockController.blockAnimator.SetTrigger("Shake");
        temp.Select();
        inputField.Select();
        if (!IsEnough())
        {
            
            Debug.Log("Yetersiz Harf");
            return;
        }
        else if(_index>5)
        {
            return;
        }
        UpdateState();
        _index++;
        inputField.text = "";

    }
    private bool IsEnough()
    {
        return inputField.text.Length == rows[_index].blockCount;
    }
}
