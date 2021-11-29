using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin6 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level6karakter player = collision.gameObject.GetComponent<level6karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
