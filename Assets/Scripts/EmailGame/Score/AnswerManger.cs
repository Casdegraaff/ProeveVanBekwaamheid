using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerManger : MonoBehaviour
{
    public static AnswerManger Instance { get; private set; }
 
    public float Score { get; private set; }
    private void Awake() 
    {
        Instance = this;   
    }

    void Update()
    {
        Debug.Log(Score);

        if(Score == 10)
        {
            SceneManager.LoadScene("EmailEndScreen");
        }
    }

    public void IncreaseScore(float amount)
    {
        Score += amount;
    }
}
