using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option1 : MonoBehaviour
{
    public GameObject Number1;

    /*public void Find()
    {
        Number1 = GameObject.Find("questionNumber1"); ;
    }*/
    public void SetText(string Text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = Text;
    }
}
