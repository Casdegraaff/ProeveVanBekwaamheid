using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopUp : MonoBehaviour
{
    //This the gameobject that displayed when hoverd
    public GameObject GameTitel;

    //Set the text to display not when game started
    public void Start()
    {
        GameTitel.SetActive(false);
    }

    //Set the text to true when you hover over the gameobject
    void OnMouseEnter()
    {
        GameTitel.SetActive(true);
    }

    //Set the text to false when you dont hover over it
    void OnMouseExit()
    {
        GameTitel.SetActive(false);
    }
}