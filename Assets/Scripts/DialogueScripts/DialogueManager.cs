using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Animator animator;
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // This manages what name and sentences will be shown and clears the previous sentences
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    //this starts te routine to display the next sentence and quits the conversation is nothing is left
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }
     //this animates the sentence to make it feel like its being generated
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                dialogueText.text += letter;
                yield return null;
            }
    }
    // this closes the dialoguebox
    void EndDialogue()
    {
        Debug.Log("end of conversation");
        animator.SetBool("IsOpen", false);
    }

}
