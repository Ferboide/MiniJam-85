using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Placeholder : MonoBehaviour
{

    public GameObject[] ingredients;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q)) Instantiate(ingredients[0]);
        if (Input.GetKeyDown(KeyCode.W)) Instantiate(ingredients[1]);
        if (Input.GetKeyDown(KeyCode.E)) Instantiate(ingredients[2]);

    }
}
