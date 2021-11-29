using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyschına3 : MonoBehaviour
{
    public float speed;
    public Transform movepoints;


    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float starttime;
    private float Waittime;

    void Start()
    {
        movepoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movepoints.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, movepoints.position) < 0.2f)
        {
            if (Waittime <= 0)
            {
                movepoints.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                Waittime = starttime;
            }
            else
            {
                Waittime -= Time.deltaTime;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(30);
        }
    }
}
