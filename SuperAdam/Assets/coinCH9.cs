using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH9 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel9 player = collision.gameObject.GetComponent<chınalevel9>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
