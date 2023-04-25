using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoice : MonoBehaviour
{
    public Button RealButton;
    public Button FakeButton;
    public GameObject Mail;

    public bool ButtonClicked = false;

    private HealthManager healthManager;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            healthManager = player.GetComponent<HealthManager>();
        }
    }

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
            healthManager.TakeDamage(20);
        }
    }

    // checks the fake button based on click
    private void FakeClick()
    {
        if (gameObject.tag == "Real")
        {
            Debug.Log("Wrong");
            healthManager.TakeDamage(20);
        }

        if (gameObject.tag == "Fake")
        {
            Debug.Log("Correct");
        }
    }

    public void HideClick()
    {
        Mail.SetActive(false);
    }
}
