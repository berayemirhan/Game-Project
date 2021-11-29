using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinABD1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            abdlevel1 player = collision.gameObject.GetComponent<abdlevel1>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
