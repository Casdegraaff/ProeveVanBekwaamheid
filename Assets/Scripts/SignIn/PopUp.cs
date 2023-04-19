using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUp : MonoBehaviour
{
    public TMP_InputField Email;
    public TMP_InputField Password; 

    public string EmailText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmailTextCheck()
    {
        if(EmailText == "")
        {
            Debug.Log("IK BEN GESELECTEERD");
        }

        else
        {
            Debug.Log("IK BEN nog niet geslecteerd");
        }
    }
}
