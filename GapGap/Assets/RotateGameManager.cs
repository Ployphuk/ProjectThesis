using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameManager : MonoBehaviour
{
    public RotateOnClick[] rotatingPictures;

    void Update()
    {
        if (CheckAllPicturesCorrect())
        {
            Debug.Log("You Win!");
        }
    }

    bool CheckAllPicturesCorrect()
    {
        foreach (var picture in rotatingPictures)
        {
            float zRotation = picture.transform.eulerAngles.z % 360;
            if (!Mathf.Approximately(zRotation, picture.correctRotationAngle))
            {
                return false;
            }
        }
        return true;
    }
}
