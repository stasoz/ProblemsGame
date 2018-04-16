using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrValues : MonoBehaviour {
    public Text currMoney;
    private void Update()
    {
        currMoney.text = Boarders.allMoney.ToString();
    }
    public void Choice1()
    {
        Boarders.currValueOfSkin = 1;
    }
    public void Choice2()
    {
        Boarders.currValueOfSkin = 2;
    }
    public void Choice3()
    {
        Boarders.currValueOfSkin = 3;
    }
    public void Choice4()
    {
        Boarders.currValueOfSkin = 4;
    }
    public void Choice5()
    {
        Boarders.currValueOfSkin = 5;
    }
    public void Choice6()
    {
        Boarders.currValueOfSkin = 6;
    }
}
