using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH6 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel6 player = collision.gameObject.GetComponent<chınalevel6>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
