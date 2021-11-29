using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin5 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level5player player = collision.gameObject.GetComponent<level5player>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
