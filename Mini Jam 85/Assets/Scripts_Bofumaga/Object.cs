using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int ID;
    
    public string[] ingredients = { "Ingrediente1", "Ingrediente2", "Ingrediente3" };


    // Start is called before the first frame update
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
            Cauldron.instance.recipe_completed.Add(this.ingredients[ID]);

        }
    }


}
