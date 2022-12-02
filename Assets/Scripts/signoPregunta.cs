using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signoPregunta : MonoBehaviour
{
    public logicaPersonaje01 logP01;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag=="saltoAlto"){
            Destroy(col.transform.parent.gameObject);
            logP01.fuerzaSalto=16.0f;
        }

        if(col.gameObject.tag=="velocidadAlta"){
            Destroy(col.transform.parent.gameObject);
            logP01.velocidadTraslacion=10.0f;
        }
    }
}
