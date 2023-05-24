using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    //Goes to scene for choosing your game
    public void RetryGame()
    {
        SceneManager.LoadScene("EmailGame");
    }
}
