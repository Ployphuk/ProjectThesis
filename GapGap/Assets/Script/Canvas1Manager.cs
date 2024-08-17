using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas1Manager : MonoBehaviour
{
    [SerializeField] GameObject CutScene1;
    [SerializeField] bool setActiveOnEnable = false; // Boolean to choose between true/false in the Inspector

    // Start is called before the first frame update
    public void OnEnable()
    {
        CutScene1.SetActive(setActiveOnEnable);
    }
}
