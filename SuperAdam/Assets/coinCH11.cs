﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCH11 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            chınalevel11 player = collision.gameObject.GetComponent<chınalevel11>();
            player.score += 5;
            gameObject.SetActive(false);
        }
    }
}
