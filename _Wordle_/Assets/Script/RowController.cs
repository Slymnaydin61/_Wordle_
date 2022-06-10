using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowController : MonoBehaviour
{
    [SerializeField] List<BlockController> blocks;
    public int blockCount => blocks.Count;
    public void UpdateText(string msg)
    {
        var arrayChar = msg.ToCharArray();
        for (int i = 0; i < blocks.Count; i++)
        {
            var block = blocks[i];

            bool isExist = i < arrayChar.Length;
            var content = isExist ? arrayChar[i] : ' ';
            block.UpdateText(content);
        }
    }
    public void UpdateState(List<State> states)
    {
        for (int i = 0; i < states.Count; i++)
        {

            blocks[i].UpdateState(states[i]);
        }
    }
}