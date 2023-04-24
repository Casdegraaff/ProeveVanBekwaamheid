using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
    private void Start()
    {
        // Call the TriggerDialogue function on the first NPC script found in the scene
        NPC npc = FindObjectOfType<NPC>();
        if (npc != null)
        {
            npc.TriggerDialogue();
        }
        else
        {
            Debug.LogWarning("No NPC found in the scene.");
        }
    }
}
