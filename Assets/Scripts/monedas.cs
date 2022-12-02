using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class monedas : MonoBehaviour
{
    public int numeroMonedas;
    public TextMeshProUGUI textoMonedas;
    //public GameObject botonMision;
    
    // Start is called before the first frame update
    void Start()
    {
        numeroMonedas=GameObject.FindGameObjectsWithTag("moneda").Length;
        textoMonedas.text="Modenedas: "+numeroMonedas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag=="moneda"){
            Destroy(col.transform.parent.gameObject);
            numeroMonedas--;
            textoMonedas.text="Modenedas: "+numeroMonedas;
            if(numeroMonedas<=0){
                textoMonedas.text="Monedas OK";
                //botonMision.SetActive(true);
            }
        }
    }
}
