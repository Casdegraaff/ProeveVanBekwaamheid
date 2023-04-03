using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEmail : MonoBehaviour
{
    // the button that u use
    public GameObject EmailButton;

    // email Gameobject
    public GameObject Email;

    // this is were the spawpoint is
    Vector3 Spawnpoint;
   
    // the spawnpoint is set here
    void Start()
    {
        Spawnpoint = new Vector3(-0.13f,0.88f,-2);
    }

    // function for spawning the email
    public void EmailSpawn()
    {
        Instantiate( Email, Spawnpoint, Quaternion.identity);
    }

    // function that turns the button off when clicked
    public void ButtonTurnOff()
    {
        EmailButton.SetActive(false);   
    }
}