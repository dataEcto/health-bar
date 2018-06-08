using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Using a tutorial from Brackeys

public class DialogueManager : MonoBehaviour {

    //John's second Captchalouge: First in, first out
    //This holds our string of sentences
    public Queue<string> sentences;
    
	// Use this for initialization
	public void Awake() {
        sentences = new Queue<string>();
   
	}

	
    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Name : " + dialogue.name);

        sentences.Clear();


        //For each sentence (A new variable i just made) in the dialogue manager, we...
        foreach (string sentence in dialogue.sentences)
        {
            //...Put the sentenceS (PLURAL!) in a queue 
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        //Get the sentence out of the Queue
        string sentence = sentences.Dequeue();

        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("End Conversation");
    }


}
