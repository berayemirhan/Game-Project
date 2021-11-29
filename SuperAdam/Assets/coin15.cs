using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin15 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level15karakter player = collision.gameObject.GetComponent<level15karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
