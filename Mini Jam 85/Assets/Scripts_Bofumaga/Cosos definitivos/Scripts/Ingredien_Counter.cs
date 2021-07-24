using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingredien_Counter : MonoBehaviour
{

    Text text;
    string size = Cauldron.instance.recipe.Count.ToString();
    public bool dcha;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        size = Cauldron.instance.recipe.Count.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (!dcha) {
            text.text = (Cauldron.instance.recipe_completed.Count.ToString());       
        }
        if (dcha)
        {
            text.text = (size);
        }

    }
}
