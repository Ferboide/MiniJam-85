using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    public Animator anim;

    public float speed;
    Vector2 mousePosition;
    RaycastHit2D cameraRaycast;
//la mano está cerrada
   public bool isClosed = false;
//la mano tiene debajo un objeto
   public bool isObject = false;
//la mano esta agarrando un objeto
   public bool isGrabbed = false;

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
            isClosed = true;
        }

        else {
            anim.SetBool("agarrando", false);
            if (Input.GetMouseButtonUp(0)) isClosed = false;
        }
        

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ingrediente")) {
           
            if (Input.GetMouseButton(0)) {
                collision.gameObject.transform.position = Vector2.Lerp(transform.position, mousePosition, speed);
               
                
            
            }

            
        }
 

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ingrediente")) isObject = true;
        if (Input.GetMouseButtonDown(0) && isObject && isClosed) isGrabbed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Ingrediente")) {
            isObject = false;
            isClosed = false;
            isGrabbed = false;
        }
    
    }
}
