using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ekranayarı : MonoBehaviour
{
    public Camera kamera;
    public SpriteRenderer cerceveAlani;
    public Text genişlik;
    public Text yükseklik;
    public Text enboyOranı;
    
    void ArayuzKontrolu()
    {
        float ekrangenisligi = Screen.width;
        float ekranyuksekligi = Screen.height;
        float ekranOrani = (float)Screen.width / (float)Screen.height;
        float yukseklıkgenislikoranı = ekrangenisligi / ekranyuksekligi;
        genişlik.text = "Genişlik" + ekrangenisligi.ToString();
        yükseklik.text = "Yükseklik" + yükseklik.ToString();
        enboyOranı.text = "En Boy Oranı" + yukseklıkgenislikoranı.ToString();
    }
    void OthographicKamera()
    {
        float ekranGenisligi = Screen.width;
        float ekranYuksekligi = Screen.height;
        float ekranOrani = ekranGenisligi / ekranYuksekligi;
        float cerceveOrani = cerceveAlani.bounds.size.x / cerceveAlani.bounds.size.y;

        if (ekranOrani >= cerceveOrani)
        {
            kamera.orthographicSize = cerceveAlani.bounds.size.y / 2;
        }
        else
        {
            float aradakiOranFarki = cerceveOrani / ekranOrani;
            kamera.orthographicSize = cerceveAlani.bounds.size.y / 2 * aradakiOranFarki;
        }

    }
    private void Update()
    {
        ArayuzKontrolu();
        OthographicKamera();
    }
}
