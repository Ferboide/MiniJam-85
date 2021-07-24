using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour
{
    public float speed;
    float h, v;

    public Transform startPosition;

    Rigidbody2D r2D;
    void Start()
    {
        r2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        r2D.velocity = new Vector2(h, v).normalized * speed;
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = startPosition.position;
    }
}
