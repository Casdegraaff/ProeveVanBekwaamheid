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
            email1.SetActive(true);
        }
        else if (gameObject.name == "Email2")
        {
            email2.SetActive(true);
        }
        else if (gameObject.name == "Email3")
        {
            email3.SetActive(true);
        }
        else if (gameObject.name == "Email4")
        {
            email4.SetActive(true);
        }
        else if (gameObject.name == "Email5")
        {
            email5.SetActive(true);
        }


        else if (gameObject.name == "Email6")
        {
            email6.SetActive(true);
        }
        else if (gameObject.name == "Email7")
        {
            email7.SetActive(true);
        }
        else if (gameObject.name == "Email8")
        {
            email8.SetActive(true);
        }
        else if (gameObject.name == "Email9")
        {
            email9.SetActive(true);
        }
        else if (gameObject.name == "Email10")
        {
            email10.SetActive(true);
        }
    }
}
