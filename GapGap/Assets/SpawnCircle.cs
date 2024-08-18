using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour
{
    public GameObject circlePrefab;
    public RectTransform canvasRect;

    public GameObject CircleSpawner()
    {
        // Calculate the size of the circle
        RectTransform circleRect = circlePrefab.GetComponent<RectTransform>();
        Vector2 circleSize = circleRect.sizeDelta;

        // Calculate the bounds for spawning positions
        Vector2 minBounds = canvasRect.rect.min + circleSize / 2;
        Vector2 maxBounds = canvasRect.rect.max - circleSize / 2;

        // Random position within the bounds
        Vector2 randomPosition = new Vector2(
            Random.Range(minBounds.x, maxBounds.x),
            Random.Range(minBounds.y, maxBounds.y)
        );

        // Instantiate the circle
        GameObject newCircle = Instantiate(circlePrefab, canvasRect);
        newCircle.GetComponent<RectTransform>().anchoredPosition = randomPosition;

        return newCircle;
    }
}
