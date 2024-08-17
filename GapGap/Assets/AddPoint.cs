using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour
{
    public int points = 0; // Variable to store the points

    // Function to increase points
    public void PlusPoint()
    {
        points += 1;
        Debug.Log("Points: " + points);
    }
}
