using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction_Area : MonoBehaviour
{
    //Detectar cuando el area entra en contacto con un alimento
    //si lo hace destruye el alimento
    // y suma a una variable el valor del item
    // y muestra el valor de esa variable en el txtScore de la escena
    void Start(){
        
    } 
    void Update(){

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hubo Collision con " + other.name);
        DetectDetroyableObject(other);
    }

    public void DetectDetroyableObject(Collider other)
    { 
        if (other.gameObject.GetComponent<AlimentoScript>().EsAlimento) {
            Destroy(other.gameObject);
        }   
    }
}
