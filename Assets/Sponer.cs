using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject squarePrefab;
    [SerializeField] float timeBetweenSpawnes;
    float elapesed = 0;
    // Start is called before the first frame update
    void Start()
    {
       // Instantiate(squarePreFab);
    }

    // Update is called once per frame
    void Update()
    {
        elapesed += Time.deltaTime; 
        if (elapesed >= timeBetweenSpawnes)
        {
            Spawn();
            elapesed = 0;
        }
    }
    private void Spawn()
    {
        GameObject g = Instantiate(squarePrefab, transform);
        int rw = Random.Range(0, Screen.width);
        int rh = Random.Range(0, Screen.height);
        g.transform.position = new Vector2(rw, rh);
        Destroy(g.gameObject, 5);
       //Debug.Log(rw);
       //Debug.Log(rh);
        
    }
}
