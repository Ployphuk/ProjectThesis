using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnimControl : MonoBehaviour
{
    [SerializeField] Animator transition;

    public void StartFade()
    {
        StartCoroutine(NextLevel());
    }

    IEnumerator NextLevel()  // Fixed return type and method name
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(1);
        transition.SetTrigger("Start");
    }
}
