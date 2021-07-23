using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagenPaginaIzquierda : MonoBehaviour
{
    public GameObject[] ingredients;

    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            img.sprite = ingredients[i].GetComponent<SpriteRenderer>().sprite;
        }
    }
}
