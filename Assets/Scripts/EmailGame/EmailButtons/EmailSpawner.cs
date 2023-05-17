using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmailSpawner : MonoBehaviour
{
    public GameObject email1;
    public GameObject email2;
    public GameObject email3;
    public GameObject email4;
    public GameObject email5;
    public GameObject email6;
    public GameObject email7;
    public GameObject email8;
    public GameObject email9;
    public GameObject email10;

    public GameObject EmailOff;

    bool WasClicked = false;

    // Start is called before the first frame update
    public void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        if (gameObject.name == "Email1")
        {
            if(!WasClicked)
            {
                email1.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email1")
        {
            if(!WasClicked)
            {
                email1.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email2")
        {
            if(!WasClicked)
            {
                email2.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email3")
        {
            if(!WasClicked)
            {
                email3.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email4")
        {
            if(!WasClicked)
            {
                email4.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email5")
        {
            if(!WasClicked)
            {
                email5.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email6")
        {
            if(!WasClicked)
            {
                email6.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email7")
        {
            if(!WasClicked)
            {
                email7.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email8")
        {
            if(!WasClicked)
            {
                email8.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email9")
        {
            if(!WasClicked)
            {
                email9.SetActive(true);
                WasClicked = true;
            }
        }

        if (gameObject.name == "Email10")
        {
            if(!WasClicked)
            {
                email10.SetActive(true);
                WasClicked = true;
            }
        }
    }
}