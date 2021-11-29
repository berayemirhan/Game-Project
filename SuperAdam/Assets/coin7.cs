using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin7 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level7karakter player = collision.gameObject.GetComponent<level7karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
