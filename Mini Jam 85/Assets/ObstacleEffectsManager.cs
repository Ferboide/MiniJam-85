using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleEffectsManager : MonoBehaviour
{

    public float time;
    public Text timerText;
    public float effectChangeTime;
    public int randomNumber;

    public GameObject smoke;
    public bool transparency = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= effectChangeTime)
        {
            randomNumber = Random.Range(1, 4);
            switch (randomNumber)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

    }

    public void ActivateSmoke()
    {
        smoke.SetActive(true);
    }



}
