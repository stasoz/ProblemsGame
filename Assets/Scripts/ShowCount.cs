using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowCount : MonoBehaviour {
    public Text countProblems;
    private int count;
    void Start()
    {
        count = 13;
        ShowCountProblems();    
    }
    void Update()
    {
        count++;
        ShowCountProblems();
    }
    void ShowCountProblems()
    {
        countProblems.text = "Avoid from problems " + count.ToString();
    }
}
