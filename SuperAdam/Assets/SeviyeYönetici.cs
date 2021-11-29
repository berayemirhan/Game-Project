using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeviyeYönetici : MonoBehaviour
{
    public static bool seviye1, seviye2,seviye3,seviye4;
    public Button seviye1_button, seviye2_button,seviye3_button,seviye4_button;
    public Image seviye1_image,seviye2_image,seviye3_image,seviye4_image;

    private void Start()
    {
        seviye1 = true;
    }
    private void Update()
    {
        if(seviye2==true)
        {
            seviye2_button.interactable = true;
            seviye1_image.enabled = false;
        }
        if(seviye3==true)
        {
            seviye3_button.interactable = true;
            seviye2_image.enabled = false;
        }
        if(seviye4==true)
        {
            seviye4_button.interactable = true;
            seviye3_image.enabled = false;
        }
    }
}
