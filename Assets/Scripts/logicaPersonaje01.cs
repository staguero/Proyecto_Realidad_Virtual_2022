using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaPersonaje01 : MonoBehaviour
{
    public float velocidadTraslacion=5f;
    public float velocidadRotacion=200f;
    private Animator anim;
    public float x,y;

    public Rigidbody rb;
    public float fuerzaSalto=8f;
    public float impulsoSalto=10000f;
    public bool  puedoSaltar;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        puedoSaltar = false;
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");

        transform.Translate(0,0,y*Time.deltaTime*velocidadTraslacion);
        transform.Rotate(0,x*Time.deltaTime*velocidadRotacion,0);  

        anim.SetFloat("velX",x);
        anim.SetFloat("velY",y);  

        if(puedoSaltar){
            //Salto
            if(Input.GetKeyDown(KeyCode.Space)){
                anim.SetBool("saltar",true);
                rb.AddForce(new Vector3(0,fuerzaSalto,0),ForceMode.Impulse);
                //transform.Translate(0,0,impulsoSalto*Time.deltaTime*velocidadTraslacion);       
            }
            //Caigo
            anim.SetBool("tocarPiso",true);
        }
        else{
            estoyCayendo();
        }
    }

    public void estoyCayendo(){
        anim.SetBool("tocarPiso",false);
        anim.SetBool("saltar",false);
    }
}
