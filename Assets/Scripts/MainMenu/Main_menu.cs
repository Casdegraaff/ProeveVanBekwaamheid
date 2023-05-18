using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Loads the scene in the game//
    public void LoadGame() 
    {
        SceneManager.LoadScene("SignInMenu");
    }

    // Quit the game
    public void Quit()
    {
        Application.Quit();
    }

    // When in game you can go back to main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene("LivingRoom");
    }

    // Function to go to the option Menu
    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionMenu");
    }
}