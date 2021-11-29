using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeviyeBitirmeChına : MonoBehaviour
{
    public void seviyebitir1Chına()
    {
        SeviyeYöneticiChina.seviye2 = true;
        SceneManager.LoadScene(21);

    }
    public void seviyebitir2()
    {
        SeviyeYöneticiChina.seviye3 = true;
        SceneManager.LoadScene(21);
    }
    public void seviyebitir3()
    {
        SeviyeYöneticiChina.seviye4 = true;
        SceneManager.LoadScene(21);
    }
    public void seviyebitir4()
    {
        SeviyeYöneticiGenel.ülke3 = true;
        SceneManager.LoadScene(19);
    }

}
