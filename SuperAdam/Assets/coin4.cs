using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin4 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level4player player = collision.gameObject.GetComponent<level4player>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
