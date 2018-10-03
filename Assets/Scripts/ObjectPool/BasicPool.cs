using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPool : MonoBehaviour {

    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject[] allPrefabs;

    public int size;

    Queue<GameObject> availableObjects = new Queue<GameObject>();
    public static BasicPool Instance { get; set; }

    private void Awake()
    {
        Instance = this;
        GrowPool();
    }

    public GameObject GetFromPool()
    {
        if(availableObjects.Count == 0)
        {
            GrowPool();
        }
        var instance = availableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }
    private void GrowPool()
    {
        for (int i = 0; i < size; i++)
        {
            int index = Random.Range(0, 6);
            prefab = allPrefabs[index];
            var instanceToAdd = Instantiate(prefab);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);
        }
    }
    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        availableObjects.Enqueue(instance);
    }

}
