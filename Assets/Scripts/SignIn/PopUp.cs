using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    //Warning text when button is Pressed
    public GameObject Warning;

    //Start function when the game is started 
    //Set the warning text false
    public void Start()
    {
        Warning.SetActive(false);
    }

    //The function that spawns the text
    public void WarningText()
    {
        Warning.SetActive(true);
    }
}
