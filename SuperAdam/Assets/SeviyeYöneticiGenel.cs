using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyeYöneticiGenel : MonoBehaviour
{
    public static bool ülke1, ülke2,ülke3,ülke4;
    public Button ülke1_button, ülke2_button,ülke3_button,ülke4_button;
    public Image ülke2_image,ülke3_image,ülke4_image;
    private void Start()
    {
        ülke1 = true;
        
    }
    private void Update()
    {
        if(ülke2==true)
        {
            ülke2_button.interactable = true;
            ülke2_image.enabled = false;
        }
        if (ülke3 == true)
        {
            ülke2_button.interactable = false;
            ülke2_image.enabled = true;
        }
       
    }
}
