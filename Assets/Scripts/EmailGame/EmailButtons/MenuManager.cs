using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
   

    // Update is called once per frame
   void retry()
   {
      SceneManager.LoadScene("EmailGame");
   }
}
