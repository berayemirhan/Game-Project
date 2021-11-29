using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class yenikarakter : MonoBehaviour
{

    Rigidbody2D rgb;
    Vector3 velocity;
    float sppedamount = 5f;
    float jumpamount = 5f;
    public Animator animator;
    public int score;
    public TextMeshProUGUI playerscoretext;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        playerscoretext.text = score.ToString();
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * sppedamount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * jumpamount, ForceMode2D.Impulse);
            animator.SetBool("Jump", true);
        }
        if (animator.GetBool("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("Jump", false);
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


    }
}
