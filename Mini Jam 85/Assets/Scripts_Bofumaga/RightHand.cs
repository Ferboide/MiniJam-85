using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    public Animator anim;

    public float speed;
    Vector2 mousePosition;
    RaycastHit2D cameraRaycast;

   public bool isGrabbing = false;
   public bool isObject = false;

    void Start()
    {
        Cursor.visible = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        transform.position=Vector2.Lerp(transform.position, mousePosition, speed);
        if (Input.GetMouseButton(0))
        {

            anim.SetBool("agarrando", true);

        }

        else anim.SetBool("agarrando", false);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        


        if (collision.CompareTag("Ingrediente") && !isGrabbing) {
            isGrabbing = true;
            if (Input.GetMouseButton(0)) {

                collision.gameObject.transform.position = Vector2.Lerp(transform.position, mousePosition, speed);
            
            }
        
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ingrediente")) isObject = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Input.GetMouseButtonUp(0) && collision.CompareTag("Ingrediente")) isObject = false;
    }
}
