using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEmail : MonoBehaviour
{
    public Sprite Email; 

    Vector3 Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        Spawnpoint = new Vector3(0,0,0);
    }

    public void EmailSpawn()
    {
        Debug.Log("I wanne Die");
        Instantiate( Email, Spawnpoint, Quaternion.identity);
    }
}
