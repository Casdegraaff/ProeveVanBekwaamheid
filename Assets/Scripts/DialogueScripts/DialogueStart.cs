using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueStart : MonoBehaviour
{
    public UnityEvent onSceneStart;

    private void Start()
    {
        onSceneStart.Invoke();
        // Call the TriggerDialogue function on the first NPC script found in the scene
     
    }
}