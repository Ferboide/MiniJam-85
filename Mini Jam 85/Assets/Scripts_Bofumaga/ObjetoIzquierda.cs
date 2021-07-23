using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoIzquierda : MonoBehaviour
{
    public GameObject[] ingredients;
    public int ID;
    public SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

      
    }


    void Update()
    {
        for (int i = 0; i <ingredients.Length; i++)
        {
            sr.sprite = ingredients[i].GetComponent<SpriteRenderer>().sprite;

        }

        Cauldron cauldron = Cauldron.instance;



    }

    

}
