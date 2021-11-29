using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH7 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevell7 player = collision.gameObject.GetComponent<chınalevell7>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
