using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin9 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level9karakter player = collision.gameObject.GetComponent<level9karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
