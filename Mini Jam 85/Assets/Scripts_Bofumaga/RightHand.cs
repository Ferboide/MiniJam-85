using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
{
    public static RightHand instance;

    public Animator anim;
    public LayerMask layer;
    public float length;

    public int counter=0;
    public float speed;

    public bool damedame = false;
    Vector2 mousePosition;

    public GameObject grabbedObject;

    RaycastHit2D hit;

    Rigidbody2D rb2d;
    CapsuleCollider2D c2d;

   // bool counter_mayor;
/*
//la mano está cerrada
   public bool isClosed = false;
//la mano tiene debajo un objeto
   public bool isObject = false;
//la mano esta agarrando un objeto
   public bool isGrabbed = false;
    //puede agarrar ob
    public bool canGrab = true;

    public bool estaGrabbed = false;
*/
    void Start()
    {
        if (instance == null) instance = this;

        Cursor.visible = false;
        anim = GetComponent<Animator>();
        c2d = GetComponent<CapsuleCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        transform.position=Vector2.Lerp(transform.position, mousePosition, speed);

        hit = Physics2D.Raycast(transform.position, Vector2.up, length, layer);
        Debug.DrawRay(transform.position, Vector2.up,Color.red);
        Debug.Log(hit);

        if (Input.GetMouseButtonDown(0) && hit) {

            grabbedObject = hit.collider.gameObject;
        
        
        }


        if (Input.GetMouseButton(0) && grabbedObject !=null)
        {
            Rigidbody2D rb = grabbedObject.GetComponent<Rigidbody2D>();
            rb.freezeRotation = true;
            rb.isKinematic = true;
            grabbedObject.transform.position = transform.position;
            damedame = true;
        }   
        if (Input.GetMouseButtonUp(0) && grabbedObject != null) {

            Rigidbody2D rb = grabbedObject.GetComponent<Rigidbody2D>();
            rb.freezeRotation = false;
            rb.isKinematic = false;
            damedame = false;

            rb.velocity = rb2d.velocity;

            grabbedObject = null;
        }

        if (Input.GetMouseButton(0))
        {
            anim.SetBool("agarrando", true);
            //  isClosed = true;
        }

        else {
            anim.SetBool("agarrando", false);
           
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       // if (collision.CompareTag("Ingrediente") || collision.CompareTag("Potion"))// isObject = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ingrediente") || collision.CompareTag("Potion")) {
            if (Input.GetMouseButtonDown(0)) {
             //   canGrab = false;
               // isGrabbed = true;

/*
                grabbedObject = collision.gameObject;
                Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();

                collision.transform.parent = transform;
                rb.freezeRotation = true;
                rb.isKinematic = true;
*/
            }


            if (Input.GetMouseButton(0)) {

                //collision.gameObject.transform.position = Vector2.Lerp(transform.position, mousePosition, object_speed);

             

                
               // c2d.enabled = false;
               


            }
            if (Input.GetMouseButtonUp(0)) {
             /*  
                Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();

                // c2d.enabled = true;
                //c2d.isTrigger = true;

                if (grabbedObject != null)
                {
                    grabbedObject.transform.parent = null;
                    grabbedObject = null;
                    rb.freezeRotation = false;
                    rb.isKinematic = false; */
                }
            //    isClosed = false;
            //    isGrabbed = false;

            //    canGrab = true;

                // rb.velocity = rb2d.velocity;
            }


        }
 

    }


   /* private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Ingrediente")|| collision.CompareTag("Potion")) {
            //isObject = false;
            

            if (Input.GetMouseButtonUp(0)) counter--;
            
        }
    
     


    } */
//}
