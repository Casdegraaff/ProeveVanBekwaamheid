using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoice : MonoBehaviour
{
    //The buttons and mail
    public Button CorrectButton;
    public Button IncorrectButton;
    public GameObject Mail;

    //Amount of answered questions
    public static AnswerManager Instance;

    //The manager for the healthbar
    private HealthManager healthManager;

    //Check if the email is real
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

        CorrectButton.onClick.AddListener(CorrectButtonClicked);
        IncorrectButton.onClick.AddListener(WrongButtonClicked);
    }

    
    // this checks of the email is fake or not, and sees if you choose the correct answer
    public void CorrectButtonClicked()
    {
        if(isRealMail){
            GoodChoice();
            return;
        }
        GoodChoice();
    }

    public void WrongButtonClicked()
    {
        if(!isRealMail){
            WrongChoice();
            return;
        }
        WrongChoice();
    }

    //if the answer is correct this function will play
    public void GoodChoice()
    {
        AnswerManager.Instance.IncreaseScore(1);
        print("CORRECT");
    }

    //  this function reduces health if the wrong choice has been made
    public void WrongChoice()
    {
        AnswerManager.Instance.IncreaseScore(1);
        print("wrong");
        healthManager.TakeDamage(20);
    }

    //Hides the email when buttons is pressed
    public void HideClick()
    {
        Mail.SetActive(false);
    }
}