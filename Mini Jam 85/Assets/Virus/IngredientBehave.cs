using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientBehave : MonoBehaviour
{
    Rigidbody2D rb2D;
    SpriteRenderer rndr;
    public float speedX, speedY, alpha;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rndr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        switch(GameManager.instance.currentEffectS)
        {
            case "ZigZag":
                ZigZag();
                break;
            case "Invert":
                InvertGravity();
                break;
            case "Transparent":
                Invisibility();
                break;
            case "None":
                DefaultColor();
                DefaultSpeed();
                break;
        }
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
}
