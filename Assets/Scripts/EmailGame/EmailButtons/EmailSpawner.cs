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
    }
}
