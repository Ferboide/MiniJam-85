using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pociones : MonoBehaviour
{
    public int dificultad;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Caldero"))
        {
            Destroy(gameObject);
            
            /*
            if (dificultad = 1)
            if (dificultad = 2)
            if (dificultad = 3) 
            */
        }
    }
}
