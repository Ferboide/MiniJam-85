using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagenPaginaIzquierda : MonoBehaviour
{
    public bool right;

    public GameObject[] ingredients;
    public string[] ingredients_toString = { "Ingrediente1", "Ingrediente2", "Ingrediente3" };
    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        /* for (int i = 0; i < ingredients.Length; i++)
         {
             img.sprite = ingredients[i].GetComponent<SpriteRenderer>().sprite;
         }
        */
        Cauldron cauldron = Cauldron.instance;

        if (!right) {   
            if (cauldron.recipe.Count == 0) gameObject.SetActive(false);
            ChangeSprite(0,0);
            ChangeSprite(0,1);
            ChangeSprite(0,2);
        }
        if (right){
            if (cauldron.recipe.Count == 1) gameObject.SetActive(false);
            ChangeSprite(1, 0);
            ChangeSprite(1, 1);
            ChangeSprite(1, 2);
        }
    }

    void ChangeSprite(int posicion, int posicion_ing) {
        Cauldron cauldron = Cauldron.instance;
        if (cauldron.recipe[posicion] == ingredients_toString[posicion_ing]) img.sprite = ingredients[posicion_ing].GetComponent<SpriteRenderer>().sprite;
    }

}
