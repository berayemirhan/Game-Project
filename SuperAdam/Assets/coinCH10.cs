using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH10 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel10 player = collision.gameObject.GetComponent<chınalevel10>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
