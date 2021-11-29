using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin10 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level10karakter player = collision.gameObject.GetComponent<level10karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
