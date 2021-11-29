using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH14 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel14 player = collision.gameObject.GetComponent<chınalevel14>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
