using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

   //checks if the answer is correct or not
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Wrong answer");
            quizManager.wrong();
        }
    }
}
