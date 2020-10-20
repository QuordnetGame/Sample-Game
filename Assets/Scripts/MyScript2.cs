using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScript2 : MonoBehaviour
{
    public GameObject TextBox2;
    public static int Number2;


    public void RandomGenerate()
    {
        Number2 = Random.Range(1, 51);

        TextBox2.GetComponent<Text>().text = Number2.ToString("0");
        //return Number2;
    }
}