using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game : MonoBehaviour
{
    //Sets the animator
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Asks for the animator
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the mouse got pressed down
        if(Input.GetMouseButtonDown(0))
        {
            //Set the raycast to where the camera is pointing
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            //If the raycast hit something asks for info
            if (Physics.Raycast(ray, out hitInfo))
            {
                //The function for the first game checks for the tag Email
                if (hitInfo.collider.gameObject.tag == "Email")
                {
                    //Trigger that the Email animation is played
                    animator.SetTrigger("Email");
                }

                //The function for the second game checks for the tag Quiz
                if (hitInfo.collider.gameObject.tag == "Quiz")
                {
                    //Trigger that the Quiz animation is played
                    animator.SetTrigger("Quiz");
                }
            }
        }
    }

    //Function whe the animation is finished you go to the Email game
    public void EndEmail()
    {
        SceneManager.LoadScene("EmailGame");
    }

    //Function that when animation is finished you go to the Quiz game
    public void EndQuiz()
    {
        SceneManager.LoadScene("Quizgame");
    }
}