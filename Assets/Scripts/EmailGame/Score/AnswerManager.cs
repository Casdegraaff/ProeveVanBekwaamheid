using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerManager : MonoBehaviour
{
    //Here is the saved value
    public static AnswerManager Instance { get; private set; }
 
    //Score variable
    public float Score { get; private set; }
    private void Awake() 
    {
        Instance = this;   
    }

    void Update()
    {
        //Function when the score hits 10 answers you go to end screen 
        if(Score == 10)
        {
            SceneManager.LoadScene("EmailEndScreen");
        }
    }

    //Function that increases the score by the amount you set
    public void IncreaseScore(float amount)
    {
        Score += amount;
    }
}
