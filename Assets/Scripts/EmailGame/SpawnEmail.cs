using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEmail : MonoBehaviour
{
    //Email Gameobject//
    public GameObject Email;

    //This is were the spawpoint is//
    Vector3 Spawnpoint;
   
    //The spawnpoint is set here//
    void Start()
    {
        Spawnpoint = new Vector3(-0.13f,0.88f,-2);
    }

    //Function for spawning the email//
    public void EmailSpawn()
    {
        Instantiate( Email, Spawnpoint, Quaternion.identity);
    }
}
