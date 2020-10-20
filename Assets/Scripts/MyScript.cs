using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    public GameObject TextBox1;
    public static int Number1;


    public void RandomGenerate()
    {
        Number1 = Random.Range(1, 51);

        TextBox1.GetComponent<Text>().text = Number1.ToString("0");
        //return Number1;
    }
}