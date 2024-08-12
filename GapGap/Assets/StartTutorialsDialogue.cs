using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class StartTutorialsDialogue : MonoBehaviour
{
    [SerializeField] private NPCConversation npcConversation;
    public void Start()
    {
        Debug.Log("Conversations start");
        ConversationManager.Instance.StartConversation(npcConversation);
    }

    


}
