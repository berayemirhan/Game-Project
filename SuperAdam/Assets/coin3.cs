using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level3player player = collision.gameObject.GetComponent<level3player>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
