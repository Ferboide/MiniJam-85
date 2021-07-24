using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public float time;
    public Text timerText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString("F2");
        if (time <= 0)
        {
            TimeUp();
        }
    }
    void TimeUp()
    {
        Debug.Log("TIME UP");
        this.enabled = false;
    }
}
