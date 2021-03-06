﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private void Awake()
    {
        Load();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void Load()
    {
        Boarders.currValueOfSkin = PlayerPrefs.GetInt("skin", Boarders.currValueOfSkin);
        Boarders.allMoney = PlayerPrefs.GetInt("money", Boarders.allMoney);
        Boarders.arrValue[0] = PlayerPrefs.GetInt("value1", Boarders.arrValue[0]);
        Boarders.arrValue[1] = PlayerPrefs.GetInt("value2", Boarders.arrValue[1]);
        Boarders.arrValue[2] = PlayerPrefs.GetInt("value3", Boarders.arrValue[2]);
        Boarders.arrValue[3] = PlayerPrefs.GetInt("value4", Boarders.arrValue[3]);
        Boarders.arrValue[4] = PlayerPrefs.GetInt("value5", Boarders.arrValue[4]);
        Boarders.arrValue[5] = PlayerPrefs.GetInt("value6", Boarders.arrValue[5]);
    }
}
