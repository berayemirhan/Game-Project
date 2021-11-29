using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH3 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel3r player = collision.gameObject.GetComponent<chınalevel3r>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
