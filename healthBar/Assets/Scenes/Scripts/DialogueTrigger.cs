using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

   public Dialogue dialogue;
    
   public void Start()
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        Debug.Log("Starting Trigger");
        //Dang it make sure the object youre trying to find is actually in the scene lol
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}

