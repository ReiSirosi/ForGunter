using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoints : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float speed = 5f;

    private int currentPointIndex = 0;
    private int direction = 1;

    private void FixedUpdate()
    {
        Transform currentPoint = points[currentPointIndex];
        Vector3 directionToCurrentPoint = (currentPoint.position - transform.position).normalized;
        transform.position += speed * Time.fixedDeltaTime * directionToCurrentPoint;

        if (Vector3.Distance(transform.position, currentPoint.position) < 0.1f)
        {
            currentPointIndex += direction;
            if (currentPointIndex >= points.Length || currentPointIndex < 0)
            {
                direction *= -1;
                currentPointIndex += direction;
            }
        }
    }
}