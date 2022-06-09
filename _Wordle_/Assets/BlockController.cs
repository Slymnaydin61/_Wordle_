using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BlockController : MonoBehaviour
{
    [SerializeField] Color colorCorrect;
    [SerializeField] Color colorExist;
    [SerializeField] Color colorFailed;
    [SerializeField] Color colorNone;

    [SerializeField] Image background;
    [SerializeField] TextMeshProUGUI blockText;

    public void UpdateText(char letter)
    {
        blockText.SetText(letter.ToString());
    }
    public void UpdateState(State state)
    {
        background.color = GetColor(state);

    }   
    Color GetColor(State state)
    {
        return state switch
        {
            State.None => colorNone,
            State.Correct => colorCorrect,
            State.Exist => colorExist,
            State.Failed => colorFailed,
        };
       
    }

}
public enum State
{
    None,
    Exist,
    Correct,
    Failed,
}
