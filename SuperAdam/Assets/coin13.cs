﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin13 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level13karakter player = collision.gameObject.GetComponent<level13karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
