using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin11 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level11karakter player = collision.gameObject.GetComponent<level11karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
