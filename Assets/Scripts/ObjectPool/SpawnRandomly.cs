using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour {

    [SerializeField]
    private float delay;
    
    private float lastTime;

    private void Update()
    {
        if(Time.time-lastTime>delay)
        {
            SpawnBombFromPool();
        }
    }
    void SpawnBombFromPool()
    {
        lastTime = Time.time;
        Vector2 position = new Vector2(Random.Range(-2.5f,2.5f),5.5f);

        var bomb = BasicPool.Instance.GetFromPool();
        bomb.transform.position = position;
    }
}
