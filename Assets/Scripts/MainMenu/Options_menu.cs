using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Options_menu : MonoBehaviour
{
    // This is de audioMixer for the master volume
    public AudioMixer audioMixer;

    // Volume Settings
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Makes that the game go fullscreen
    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    // To go back to the main menu
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
