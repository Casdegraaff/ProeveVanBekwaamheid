using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceButton : MonoBehaviour 
{ 
    public Button RealButton;
    public Button FakeButton;


    public bool ButtonClicked = false;

    // function for clicking the real button
    public void Real()
    {
        if (!ButtonClicked)
        {
            RealButton.onClick.AddListener(RealClick);
            ButtonClicked = true;
        }
    }

    // function for clicking the fake button
    public void Fake()
    {
        if (!ButtonClicked)
        {
            FakeButton.onClick.AddListener(FakeClick);
            ButtonClicked = true;
        }
    }

    // checks the real button based on click
    private void RealClick()
    {
        if (gameObject.tag == "Real")
        {
            Debug.Log("Correct");

        }

        if (gameObject.tag == "Fake")
        {
            Debug.Log("Wrong");
        }
    }

    // checks the fake button based on click
    private void FakeClick()
    {
        if (gameObject.tag == "Real")
        {
            Debug.Log("Wrong");
        }

        if (gameObject.tag == "Fake")
        {
            Debug.Log("Correct");
        }
    }
}
