using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH4 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel4 player = collision.gameObject.GetComponent<chınalevel4>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
