using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                //The function for the first game checks for tag 1
                if (hitInfo.collider.gameObject.tag == "Email")
                {
                    Debug.Log("tag");
                    animator.SetTrigger("Email");
                }

                //The funciton for the second game checks for tag 2
                if (hitInfo.collider.gameObject.tag == "Game2")
                {
                    Debug.Log("tag");
                    animator.SetTrigger("Game2");
                }
            }
         }
    }
}
