using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH13 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel13 player = collision.gameObject.GetComponent<chınalevel13>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
