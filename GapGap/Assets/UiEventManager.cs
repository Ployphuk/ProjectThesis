using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiEventManager : MonoBehaviour
{
    [SerializeField] GameObject tutorialsUi;
    
    public void EnableTutorialUi()
    {
        tutorialsUi.SetActive(true);
    }
}
