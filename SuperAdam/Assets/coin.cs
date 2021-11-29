using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            KarakterScript player = collision.gameObject.GetComponent<KarakterScript>();
            player.score += 5;
            
            
            gameObject.SetActive(false);
        }
    }
}
