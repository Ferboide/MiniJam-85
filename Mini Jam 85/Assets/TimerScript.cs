using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public static TimerScript instance;

    public float time;
    public Text timerText;



    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString("F2");
        if (time <= 0)
        {
            TimeUp();
            Debug.Log("perdiste");
        }

        if (Cauldron.instance.recipe.Count == 0) {
           
            Debug.Log("ganaste");
            this.enabled = false;

        }
      

    }
    void TimeUp()
    {
        Debug.Log("TIME UP");
        this.enabled = false;
    }
}
