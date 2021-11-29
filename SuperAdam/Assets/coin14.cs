using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin14 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level14karakter player = collision.gameObject.GetComponent<level14karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
