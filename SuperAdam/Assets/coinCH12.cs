using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH12 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel12 player = collision.gameObject.GetComponent<chınalevel12>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
