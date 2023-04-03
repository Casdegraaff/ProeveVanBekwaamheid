using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Dialogue
{
    //This grabs the name and sentences you put on the hierarcy and limits it to 10 characters and 3 lines
    public string name;
    [TextArea(3 ,10)]
    public string[] sentences;
  
}
