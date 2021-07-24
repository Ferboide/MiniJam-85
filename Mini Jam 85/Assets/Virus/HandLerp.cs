using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLerp : MonoBehaviour
{
    public Transform handPos;
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, handPos.position, 0.6f);
    }
}
