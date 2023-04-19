using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUp : MonoBehaviour
{
    //Is the inputfield for the emailAdress
    public TMP_InputField InputEmail;

    //Is the inputfield for the Password
    public TMP_InputField InputPassword; 

    //Email text what wil be filled in in inputfield
    public string EmailText;

    //Password text what wil be filled in in inputfield
    public string PasswordText;

    //Warning text when button is Pressed
    public Text Warning;

    //This function is not build yet
    public void EmailTextCheck()
    {
        EmailText = InputEmail.text;
        PasswordText = InputPassword.text;
    }

    //The function that spawns the text
    public void WarningText()
    {
        Warning.enabled = true;
    }
}
