using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel1 player = collision.gameObject.GetComponent<chınalevel1>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
