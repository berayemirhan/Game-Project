﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin8 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level8karakter player = collision.gameObject.GetComponent<level8karakter>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
