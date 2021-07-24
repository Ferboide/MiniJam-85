using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject topSpawn, bottomSpawn;

    public int score = 0;

    float time;

    public bool isInverted;

    public enum Effects { Zigzag, Invert, Invisible, Cloudy }
    Effects effect;
    
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchEffect(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Effects currentEffect;
    IEnumerator SwitchEffect(float time)
    {
        yield return new WaitForSeconds(time);
        switch (effect)
        {
            case Effects.Zigzag:
                break;
            case Effects.Invert:
                break;
            case Effects.Invisible:
                break;
            case Effects.Cloudy:
                break;
            default:
                break;
        }
        StartCoroutine(SwitchEffect(time));
    }
}
