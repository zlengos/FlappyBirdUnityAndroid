using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float timeToSpawn, minYPosition, maxYPosition;
    private float timer;


   


    private void Update()
    {
        if (timer <= 0)  
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            float rand = Random.Range (minYPosition, maxYPosition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, rand, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
