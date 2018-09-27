using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject[] menuItems;
    public GameObject[] settingsItems;

    public void HiddenMenuItems()
    {
        foreach(GameObject i in menuItems) i.SetActive(false);
        foreach (GameObject i in settingsItems) i.SetActive(true);
    }
    public void UnhiddenMenuItems()
    {
        foreach (GameObject i in menuItems) i.SetActive(true);
        foreach (GameObject i in settingsItems) i.SetActive(false);
    }
}
