using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientBehave : MonoBehaviour
{
    Rigidbody2D rb2D;
    SpriteRenderer rndr;
    public float speedX, speedY, alpha;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rndr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DefaultSpeed()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, speedY);
    }
    void DefaultColor()
    {
        if (rndr.color.a < 255)
        {
            rndr.color = new Color(rndr.color.r, rndr.color.g, rndr.color.b, Mathf.Lerp(rndr.color.a, 255, 0.15f));
        }
    }
    void ZigZag()
    {
        rb2D.velocity = new Vector2(Mathf.Cos(Time.deltaTime) * speedX, speedY);
    }

    void InvertGravity()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, Mathf.Abs(rb2D.velocity.y));
    }

    void Invisibility()
    {
        rndr.color = new Color(rndr.color.r, rndr.color.g, rndr.color.b, Mathf.Lerp(rndr.color.a, alpha, 0.15f));
    }

    void Grab()
    {
        transform.position = RightHand.instance.transform.position;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (true)
        {

        }
    }
}
