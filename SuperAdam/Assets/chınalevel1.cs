using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class chınalevel1 : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    float sppedamount = 5f;
    float jumpamount = 0.4f;
    public Animator animator;
    public int score;
    public Joystick joystick;
    float HorızontalMoveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {

        rgb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()

    {
        if (joystick.Horizontal > 0.2f)
        {
            HorızontalMoveSpeed = 1;
        }
        else if (joystick.Horizontal < -0.2f)
        {
            HorızontalMoveSpeed = -1;
        }
        else
        {
            HorızontalMoveSpeed = 0;
        }
        velocity = new Vector3(joystick.Horizontal, 0f);
        transform.position += velocity * sppedamount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(joystick.Horizontal));
        if (joystick.Vertical > 0.5f && !animator.GetBool("IsJumping"))
        {
            rgb.AddForce(Vector3.up * jumpamount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);

        }
        if (HorızontalMoveSpeed == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (HorızontalMoveSpeed == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
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
        if (score == 20)
        {
            SceneManager.LoadScene(23);
        }

    }
}
