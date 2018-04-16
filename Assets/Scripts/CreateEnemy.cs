using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject[] enemy;

    private void Start()
    {
        StartCoroutine(Create());
    }
    IEnumerator Create()
    {
        while (Boarders.IsAlive)
        {
            int index = Random.Range(0, 6);
            Instantiate(enemy[index], new Vector2(Random.Range(-2.5f, 2.5f), 5.5f), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
