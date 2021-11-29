using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelyüklemegenel : MonoBehaviour
{
    public Button buton1;
    public Image lock1;
    public Text yazdırmagenel;

    void Start()
    {
        if(level16karakter.levelatlama==1)
        {
            buton1.interactable = true;
            lock1.enabled = false;
            PlayerPrefs.SetInt("deger2", 1);
            PlayerPrefs.Save();
        }
        yazdırmagenel.text = PlayerPrefs.GetInt("deger2").ToString();
        if(yazdırmagenel.text=="1")
        {
            buton1.interactable = true;
            lock1.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
