using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FallEnemy : MonoBehaviour
{
    public static float fallSpeed = 5f;
    private void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }
    private void Update()
    {
        transform.position -= new Vector3(0,fallSpeed*Time.deltaTime,0);
    }
    public void OnBecameInvisible()
    {
        Boarders.currScore++;
        Destroy(gameObject);
    }
    IEnumerator IncreaseSpeed()
    {
        while (FallEnemy.fallSpeed<=10f)
        {
            FallEnemy.fallSpeed += 0.2f;
            yield return new WaitForSeconds(1f);
        }
    }
}
