using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public GameObject[] mainButton;
    public GameObject[] select;
    public void Update()
    {
        Boarders.Save();
        CurrState();
    }
    public void Choice1()
    {
        if (Boarders.allMoney >= 10)
        {
                Boarders.arrValue[0] = 10;
                Boarders.allMoney -= 10;
        }
    }
    public void Choice2()
    {
        if (Boarders.allMoney >= 20)
        {
            Boarders.allMoney -= 20;
            Boarders.arrValue[1] = 20;
        }
    }
    public void Choice3()
    {
        if (Boarders.allMoney >= 30)
        {
            Boarders.allMoney -= 30;
            Boarders.arrValue[2] = 30;
        }
    }
    public void Choice4()
    {
        if (Boarders.allMoney >= 40)
        {
            Boarders.allMoney -= 40;
            Boarders.arrValue[3] = 40;
        }
    }
    public void Choice5()
    {
        if (Boarders.allMoney >= 50)
        {
            Boarders.allMoney -= 50;
            Boarders.arrValue[4] = 50;
        }
    }
    public void Choice6()
    {
        if (Boarders.allMoney >= 60)
        {
            Boarders.allMoney -= 60;
            Boarders.arrValue[5] = 60;
        }
    }
    void CurrState()
    {
        if (Boarders.arrValue[0] == 10)
        {
            mainButton[0].SetActive(false);
            select[0].SetActive(true);
        }
        if (Boarders.arrValue[1] == 20)
        {
            mainButton[1].SetActive(false);
            select[1].SetActive(true);
        }
        if (Boarders.arrValue[2] == 30)
        {
            mainButton[2].SetActive(false);
            select[2].SetActive(true);
        }
        if (Boarders.arrValue[3] == 40)
        {
            mainButton[3].SetActive(false);
            select[3].SetActive(true);
        }
        if (Boarders.arrValue[4] == 50)
        {
            mainButton[4].SetActive(false);
            select[4].SetActive(true);
        }
        if (Boarders.arrValue[5] == 60)
        {
            mainButton[5].SetActive(false);
            select[5].SetActive(true);
        }
    }
}
