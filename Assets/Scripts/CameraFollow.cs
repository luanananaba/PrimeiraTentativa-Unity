using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minX, maxX;
    public float minY, maxY;

    private void FixedUpdate()
    {
        transform.position = player.position + new Vector3(0, 0, -10);

        transform.position = new Vector3
    (
    Mathf.Clamp(transform.position.x, minX, maxX),
    Mathf.Clamp(transform.position.y, minY, maxY),
    transform.position.z
    );
    }
}