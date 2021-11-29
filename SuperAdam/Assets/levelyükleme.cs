using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelyükleme : MonoBehaviour
{
    public   Button button1;
    public  Text yazdır1;
    public  Image kilit1;
    public  Button button2;
    public  Image kilit2;
    public  Button button3;
    public  Image kilit3;


    void Start()
    {
        
       if( level5player.deger==1)
        {
            button1.interactable = true;
            kilit1.enabled = false;
            PlayerPrefs.SetInt("deger",1);
            PlayerPrefs.Save();
            
        }
        yazdır1.text = PlayerPrefs.GetInt("deger").ToString();

        if(yazdır1.text=="1")
        {
            button1.interactable = true;
            kilit1.enabled = false;
        }
        if(level9karakter.deger2==1)
        {
            button2.interactable = true;
            kilit2.enabled = false;
            PlayerPrefs.SetInt("deger", 2);
            PlayerPrefs.Save();
        }
        yazdır1.text = PlayerPrefs.GetInt("deger").ToString();
        if (yazdır1.text =="2")
        {
            button2.interactable = true;
            kilit2.enabled = false;
            button1.interactable = true;
            kilit1.enabled = false;
        }
        if(level13karakter.deger3==1)
        {
            button2.interactable = true;
            kilit3.enabled = false;
            PlayerPrefs.SetInt("deger", 3);
            PlayerPrefs.Save();
            
        }
        yazdır1.text = PlayerPrefs.GetInt("deger").ToString();
        if(yazdır1.text=="3")
        {
            button2.interactable = true;
            kilit2.enabled = false;
            button1.interactable = true;
            kilit1.enabled = false;
            button3.interactable = true;
            kilit3.enabled = false;
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
