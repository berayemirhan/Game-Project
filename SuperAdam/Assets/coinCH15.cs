using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH15 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel15 player = collision.gameObject.GetComponent<chınalevel15>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
