﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin12 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level12karakter player = collision.gameObject.GetComponent<level12karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
