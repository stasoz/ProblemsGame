using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    public Transform player;
    public float speed = 30f;
    public void Update()
    {
        Debug.Log(speed);
    }
    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
        mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
        player.position = Vector2.MoveTowards(player.position,   new Vector2(mousePos.x, player.position.y),   speed*Time.deltaTime);

    }
}
