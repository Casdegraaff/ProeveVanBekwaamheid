using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour
{
    //Goes to scene for choosing your game
    public void Skip()
    {
        SceneManager.LoadScene("LivingRoom");
    }
}
