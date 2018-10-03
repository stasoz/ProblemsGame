using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FallEnemy : MonoBehaviour
{
    public static float fallSpeed = 2f;   

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
        //Destroy(gameObject);
        BasicPool.Instance.AddToPool(gameObject);
    }
    IEnumerator IncreaseSpeed()
    {
        while (FallEnemy.fallSpeed <= 10f)
        {
            FallEnemy.fallSpeed += 0.1f;
            yield return new WaitForSeconds(1f);
        }
    }
}
