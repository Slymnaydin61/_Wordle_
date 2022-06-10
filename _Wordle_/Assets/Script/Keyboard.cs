using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    ContentController contentController;
    void Awake()
    {
        contentController=FindObjectOfType<ContentController>();
    }
    public void ReturnA()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "a";
    }
    public void ReturnB()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "b";
    }
    public void ReturnC()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "c";
    }
    public void ReturnÇ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "ç";
    }
    public void ReturnD()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "d";
    }
    public void ReturnE()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "e";
    }
    public void ReturnF()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "f";
    }
    public void ReturnG()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "g";
    }
    public void ReturnÐ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "ð";
    }
    public void ReturnH()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "h";
    }
    public void ReturnI()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "ý";
    }
    public void ReturnÝ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "i";
    }
    public void ReturnJ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "j";
    }
    public void ReturnK()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "k";
    }
    public void ReturnL()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "l";
    }
    public void ReturnM()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "m";
    }
    public void ReturnN()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "n";
    }
    public void ReturnO()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "o";
    }
    public void ReturnÖ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "ö";
    }
    public void ReturnP()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "p";
    }
    public void ReturnR()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "r";
    }
    public void ReturnS()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "s";
    }
    public void ReturnÞ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "þ";
    }
    public void ReturnT()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "t";
    }
    public void ReturnU()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "u";
    }
    public void ReturnÜ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "ü";
    }
    public void ReturnV()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "v";
    }
    public void ReturnY()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "Y";
    }
    public void ReturnZ()
    {
        if (contentController.inputField.text.Length > 4)
        {
            return;
        }
        contentController.inputField.text = contentController.inputField.text + "z";
    }
    public void ReturnEnter()
    {
        Input.GetKey(KeyCode.KeypadEnter);
    }
    public void ReturnBackspace()
    {
        Input.GetKey(KeyCode.Backspace);
    }
}
