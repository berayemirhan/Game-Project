using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel2 player = collision.gameObject.GetComponent<chınalevel2>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
