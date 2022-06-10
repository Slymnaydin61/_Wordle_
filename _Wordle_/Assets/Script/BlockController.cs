using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BlockController : MonoBehaviour
{
    public Animator blockAnimator;
    [SerializeField] Color colorCorrect;
    [SerializeField] Color colorExist;
    [SerializeField] Color colorFailed;
    [SerializeField] Color colorNone;

    [SerializeField] Image background;
    [SerializeField] TextMeshProUGUI blockText;
    void Awake()
    {
        blockAnimator = GetComponent<Animator>();
    }

    public void UpdateText(char letter)
    {
        blockText.SetText(letter.ToString());
    }
    public void UpdateState(State state)
    {
        int animationState=(int)state;
        blockAnimator.SetInteger("State",animationState);
        //background.color = GetColor(state);

    }   
    //Color GetColor(State state)
    //{
    //    return state switch
    //    {
    //        State.None => colorNone,
    //        State.Correct => colorCorrect,
    //        State.Contain => colorExist,
    //        State.Failed => colorFailed,
    //    };
       
    //}
}
public enum State
{
    None,
    Contain=1,
    Correct=0,
    Failed=2,
}
