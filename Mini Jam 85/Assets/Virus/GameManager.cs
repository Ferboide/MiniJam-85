using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Effects { Zigzag, Invert, Transparent, Cloudy }
    public static GameManager instance;
    public GameObject topSpawn, bottomSpawn, particleSys;
    public int score = 0;
    public float time;
    Effects currentEffect;
    public string currentEffectS;
    
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        StartCoroutine(SwitchEffect());
    }
    void Update()
    {
        if (currentEffectS=="Cloudy")
        {
            particleSys.SetActive(true);
        }
        else if (currentEffectS=="Invert")
        {
            topSpawn.SetActive(false);
            bottomSpawn.SetActive(true);
        }
        else if (bottomSpawn)
        {
            topSpawn.SetActive(true);
            bottomSpawn.SetActive(false);
        }
    }

    IEnumerator SwitchEffect()
    {
        yield return new WaitForSeconds(time);
        currentEffect = (Effects)Random.Range(0, 4);
        switch (currentEffect)
        {
            case Effects.Zigzag:
                currentEffectS = "ZigZag";
                break;
            case Effects.Invert:
                currentEffectS = "Invert";
                break;
            case Effects.Transparent:
                currentEffectS = "Transparent";
                break;
            case Effects.Cloudy:
                currentEffectS = "Cloudy";
                break;
            default:
                currentEffectS = "None";
                break;
        }
        StartCoroutine(SwitchEffect());
    }
}
