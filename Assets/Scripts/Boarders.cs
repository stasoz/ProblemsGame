using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Boarders : MonoBehaviour
{
    public Rigidbody2D rb;
    public static bool IsAlive = true;
    public GameObject background;
    public GameObject restart;
    public GameObject menu;
    public GameObject spawnObject;
    public static int allMoney;
    public Text money;
    public Text score;
    public static int currScore;
    public static int currValueOfSkin;
    private int maxScore;
    public Sprite[] skins;
    public static int[] arrValue = new int[6];
    public float dirX;
    public float xMin, xMax, yMin, yMax;

    public static int[] currSkin = new int[6];

    public void Start()
    {
        ShowMoney();
        ShowScore();
    }
    public void Update()
    {
        Save();
        ShowMoney();
        ShowScore();
        ChangeSkin();
        dirX = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
            IsAlive = false;
            background.SetActive(false);
            restart.SetActive(true);
            menu.SetActive(true);
            spawnObject.SetActive(false);
        }
        if (collision.tag == "Coin")
        {
            allMoney++;
        }
    }
    void CheckOnButtonRestart()
    {
        if (RestartGame.isClick)
        {
            restart.SetActive(false);
            menu.SetActive(false);
            RestartGame.isClick = false;
            spawnObject.SetActive(true);
        }
    }
    public void ShowMoney()
    {
        money.text = allMoney.ToString();
    }
    public void ShowScore()
    {
        score.text = "Max deviation " + currScore.ToString();
    }
    public void ChangeSkin()
    {
        #region Skin
        //if (currValueOfSkin == 1)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[0];
        //}
        //if (currValueOfSkin == 2)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[1];
        //}
        //if (currValueOfSkin == 3)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[2];
        //}
        //if (currValueOfSkin == 4)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[3];
        //}
        //if (currValueOfSkin == 5)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[4];
        //}
        //if (currValueOfSkin == 6)
        //{
        //    rb.GetComponent<SpriteRenderer>().sprite = skins[5];
        //}
        #endregion
        if (currValueOfSkin > 0 && currValueOfSkin <= skins.Length - 1)
        {
            rb.GetComponent<SpriteRenderer>().sprite = skins[currValueOfSkin - 1];
        }
    }
    public static void Save()
    {
        PlayerPrefs.SetInt("skin", currValueOfSkin);
        PlayerPrefs.SetInt("money", allMoney);
        //PlayerPrefs.SetInt("value1", arrValue[0]);
        //PlayerPrefs.SetInt("value2", arrValue[1]);
        //PlayerPrefs.SetInt("value3", arrValue[2]);
        //PlayerPrefs.SetInt("value4", arrValue[3]);
        //PlayerPrefs.SetInt("value5", arrValue[4]);
        //PlayerPrefs.SetInt("value6", arrValue[5]);
        for(int i=0;i<arrValue.Length;i++)
        {
            PlayerPrefs.SetInt("value" + i+1.ToString(), arrValue[i]);
        }
        PlayerPrefs.Save();
    }
    public void Move()
    {
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x, xMin, xMax),
                Mathf.Clamp(rb.position.y, yMin, yMax),
                0.0f
            );
    }
}

