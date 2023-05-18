using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public GameObject answerButton;

   //checks if the answer is correct or not
    public void Answer()
    {
        if (isCorrect)
        {
            quizManager.correct();
            answerButton.GetComponent<Image>().color = Color.green;
            Invoke("ColorChange", 0.4f);
        }
        else
        {
            quizManager.wrong();
            answerButton.GetComponent<Image>().color = Color.red;
            Invoke("ColorChange", 0.4f);
        }
    }

    public void ColorChange()
    {
        answerButton.GetComponent<Image>().color = Color.white;
    }
}
