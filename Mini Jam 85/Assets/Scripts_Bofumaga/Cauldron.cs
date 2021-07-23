using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public static Cauldron instance;

    public int size;


    public List<string> recipe = new List<string>();
    public List<string> recipe_completed = new List<string>();
    public string[] ingredients = { "Ingrediente1", "Ingrediente2", "Ingrediente3" };
    
    void Start()
    {
        if (instance == null) instance = this;

        for (int i = 0; i <= size; i++)
        {
            recipe.Add(ingredients[Random.Range(0, ingredients.Length)]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


  
}
