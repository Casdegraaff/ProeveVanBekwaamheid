using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GameOverPanel;

    public TMP_Text QuestionText;
    public TMP_Text ScoreText;

    public int totalQuestions = 0;
    public int score;

    // generates a question
    private void Start()
    {
        totalQuestions = QnA.Count;
        GameOverPanel.SetActive(false);
        generateQuestion();
    }

    // Lets you load the scene again upon button press
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // When you answered the last question, the panel changes to the game over panel
    public void GameOver()
    {
        QuizPanel.SetActive(false);
        GameOverPanel.SetActive(true);
        // The score is based on "question correct answers" / "Amount of questions"
        ScoreText.text = score + "/" + totalQuestions;
    }

    // if question is answered correctly, you get a point and a new question generates
    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    //if question is answered incorrectly, a new question generates
    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    // You get to choose a correct answer for a question
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    // makes the questions generate randomly
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        // when the last question got answered, it triggers the GameOver() function
        else
        {
            Debug.Log("No questions left");
            GameOver();
        }
    }
}