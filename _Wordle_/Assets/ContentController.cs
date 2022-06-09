using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContentController : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] List<RowController> rows;

    int _index;
    void Start()
    {
        inputField.onValueChanged.AddListener(OnUpdateContent);
    }
    void OnUpdateContent(string msg)
    {
        var row = rows[_index];
        row.UpdateText(msg);
    }
}
