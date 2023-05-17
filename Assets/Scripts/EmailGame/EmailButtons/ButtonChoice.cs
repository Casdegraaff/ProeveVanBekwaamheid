using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoice : MonoBehaviour
{
    public Button RealButton;
    public Button FakeButton;
    public GameObject Mail;
    public static AnswerManger Instance;
    //How many Questions are answerd
    public int Answers = 0;

    private HealthManager healthManager;
    private bool isRealMail;

    // this function grabs the players object and health, as well as add a listener to see what button is correct
    private void Awake()
    {
        isRealMail = gameObject.tag == "Real";
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            healthManager = player.GetComponent<HealthManager>();
        }

        RealButton.onClick.AddListener(CorrectButtonClicked);
        FakeButton.onClick.AddListener(WrongButtonClicked);
    }

    
    // this checks of the email is fake or not, and sees if you choose the correct answer
    public void CorrectButtonClicked()
    {
        if(isRealMail){
            GoodChoice();
            return;
        }
        GoodChoice();
        WrongChoice();
        Answers+= 1;
    }

    public void WrongButtonClicked()
    {
        AnswerManger.Instance.IncreaseScore(1);
        if(!isRealMail){
            GoodChoice();
            return;
        }
        WrongChoice();
        Answers+= 1;
    }

    //if the answer is correct this function will play
    public void GoodChoice()
    {
        AnswerManger.Instance.IncreaseScore(1);
        print("CORRECT");
    }

    //  this function reduces health if the wrong choice has been made
    public void WrongChoice()
    {
        print("wrong");
        healthManager.TakeDamage(20);
    }

    //Hides the email when buttons is pressed
    public void HideClick()
    {
        Mail.SetActive(false);
    }
}