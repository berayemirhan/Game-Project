using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelyüklemechına : MonoBehaviour
{
    public Button buton1;
    public Image lock1;
    public Text yazdırma;
    public Button buton2;
    public Image lock2;
    public Button buton3;
    public Image lock3;

    void Start()
    {
        if(chınalevel5.deger1_chına==1)
        {
            buton1.interactable = true;
            lock1.enabled = false;
            PlayerPrefs.SetInt("deger1", 1);
            PlayerPrefs.Save();
        }
        yazdırma.text = PlayerPrefs.GetInt("deger1").ToString();
        
        if(yazdırma.text=="1")
        {
            buton1.interactable = true;
            lock1.enabled = false;
        }
        if(chınalevel9.deger2_chına==1)
        {
            buton2.interactable = true;
            lock2.enabled = false;
            PlayerPrefs.SetInt("deger1", 2);
            PlayerPrefs.Save();

        }
        yazdırma.text = PlayerPrefs.GetInt("deger1").ToString();
        if(yazdırma.text=="2")
        {
            buton1.interactable = true;
            buton2.interactable = true;
            lock1.enabled = false;
            lock2.enabled = false;
        }
        if(chınalevel13.deger3_chına==1)
        {
            buton3.interactable = true;
            lock3.enabled = false;
            buton1.interactable = true;
            buton2.interactable = true;
            lock1.enabled = false;
            lock2.enabled = false;
            PlayerPrefs.SetInt("deger1", 3);
            PlayerPrefs.Save();
        }
        yazdırma.text = PlayerPrefs.GetInt("deger1").ToString();

        if(yazdırma.text=="3")
        {
            buton3.interactable = true;
            lock3.enabled = false;
            buton1.interactable = true;
            buton2.interactable = true;
            lock1.enabled = false;
            lock2.enabled = false;
        }
    }

    
    void Update()
    {
        
    }
}
