using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    //Agregar una variable que alamacene el valor máximo de puntos
    //cuando se llegue al valor máximo debe dejar de sumarse puntos
    // y mostrar en txtScore en lugar del puntaje el mensaje "Ganaste!"

    public int score = 0;
    public Text text;
    public int WinnerPoints = 200;

    void Start(){
        
    }
    void Update() {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hubo Collision con " + other.name);
        ChangeScoreText(other);
    }
    public void ChangeScoreText(Collider other)
    { 
        if (score < WinnerPoints)
        {    
            score += other.gameObject.GetComponent<AlimentoScript>().valorAlimentario;
            if (score >= WinnerPoints) {
                text.text = "Ganaste!";
            }
            else {
                text.text = "SCORE: " + score;
            }       
        }
    }
}
