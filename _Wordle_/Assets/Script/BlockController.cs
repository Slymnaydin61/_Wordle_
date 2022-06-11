using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BlockController : MonoBehaviour
{
    public Animator blockAnimator;

    [SerializeField] Image background;
    [SerializeField] TextMeshProUGUI blockText;
    public int animationState;
    void Awake()
    {
        blockAnimator = GetComponent<Animator>();
    }

    public void UpdateText(char letter)
    {
        blockText.SetText(letter.ToString());
    }
    public void UpdateState(LetterState state)
    {
        animationState=(int)state;
        blockAnimator.SetInteger("State",animationState);

    }   

}

