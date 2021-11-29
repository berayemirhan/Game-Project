using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin16 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level16karakter player = collision.gameObject.GetComponent<level16karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
