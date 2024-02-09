using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
     public GameObject pipe;

    int counter = 0;
    public static int spawntime = 444;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(counter == spawntime)
        {
            Instantiate(pipe, new Vector2(10f,Random.Range(-3f,3f)), transform.rotation);
            counter = 0;
        }
    }
}
