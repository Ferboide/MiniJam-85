using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Rigidbody2D x;
    public float cooldown, minX = -8, maxX = 8;
    public GameObject[] ings;
    void Start()
    {
        x = GetComponent<Rigidbody2D>();
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(cooldown);
        Instantiate(ings[Random.Range(0,ings.Length)],new Vector2(Random.Range(minX, maxX),transform.position.y),Quaternion.identity);
        StartCoroutine(Spawn());
    }
    
}
