using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cronometro : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    //private Text tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tiempo.text=Time.time.ToString();
        textoTiempo.text="Tiempo: "+ Time.time.ToString("f0");
    }
}
