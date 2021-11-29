using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonenabled : MonoBehaviour
{
    public UnityEngine.UI.Button buton;
    public UnityEngine.UI.Button buton1;

    private void Start()
    {
        buton.gameObject.SetActive(false);
        buton1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
