using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirme : MonoBehaviour
{
    public void seviyebitir()
    {
        SeviyeYönetici.seviye2 = true;
        SceneManager.LoadScene(20);
        
    }
    public void seviyebitir2()
    {
        SeviyeYönetici.seviye3 = true;
        SceneManager.LoadScene(20);
    }
    public void seviyebitir3()
    {
        SeviyeYönetici.seviye4 = true;
        SceneManager.LoadScene(20);
    }
    public void seviyebitir4()
    {
        SeviyeYöneticiGenel.ülke2 = true;
        SceneManager.LoadScene(19);
    }
}
