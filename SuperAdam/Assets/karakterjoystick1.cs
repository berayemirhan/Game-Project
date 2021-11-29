using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterjoystick1 : MonoBehaviour
{
    float vertical, horizontal;
    public int speed;
    public Joystick jy;

    private void FixedUpdate()
    {
        vertical = jy.Vertical;
        horizontal = jy.Horizontal;
        if(vertical!=0||horizontal!=00)
        {
            transform.up = new Vector3(horizontal * speed, vertical * speed, 0);
            transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime,Space.World);
        }

       
        
    }

}
