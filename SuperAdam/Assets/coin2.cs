using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            lvl2player player= collision.gameObject.GetComponent<lvl2player>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
