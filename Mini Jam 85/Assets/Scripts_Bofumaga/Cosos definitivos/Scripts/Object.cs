using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public int ID;
    
    public string[] ingredients;


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
            if (Cauldron.instance.recipe[0] == this.ingredients[ID])
            {
                Cauldron.instance.recipe_completed.Add(this.ingredients[ID]);
                Cauldron.instance.recipe.RemoveAt(0);
                Cauldron.instance.borrado = true;
                Cauldron.instance.audioSrc.PlayOneShot(Cauldron.instance.splash);
            }
            else {
                Cauldron.instance.audioSrc.PlayOneShot(Cauldron.instance.splash);
                Cauldron.instance.audioSrc.PlayOneShot(Cauldron.instance.error);
            }
            
        }
    }


}
