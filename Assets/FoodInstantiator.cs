using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiator : MonoBehaviour
{
    //Agregar una variable que establezca la cantidad de 
    //veces que se instanciará un alimento
    //cuando se instancien esa cantidad de alimentos
    //no deben instanciarse más

    public int cant_Instantiate_Manzana = 1;
    public int cant_Instantiate_Filete = 1;
    public int cant_Instantiate_Lata = 1;

    public GameObject Manzana_Prefab;
    public GameObject Filete_Prefab;
    public GameObject Lata_Prefab;

    public float AlturaInstantiateOBJ = 2;
    void Start()
    {
        InstantiateOBJ();
    }  
    void Update(){
        
    }

    public void InstantiateOBJ() 
    {
        for (int i = 0; i < cant_Instantiate_Manzana; i++)
        {
            Instantiate(Manzana_Prefab, new Vector3(Random.Range(-10f, 10f), AlturaInstantiateOBJ, Random.Range(-10f, 10f)), Quaternion.identity);
        }
        for (int i = 0; i < cant_Instantiate_Filete; i++)
        {
            Instantiate(Filete_Prefab, new Vector3(Random.Range(-10f, 10f), AlturaInstantiateOBJ, Random.Range(-10f, 10f)), Quaternion.identity);
        }
        for (int i = 0; i < cant_Instantiate_Lata; i++)
        {
            Instantiate(Lata_Prefab, new Vector3(Random.Range(-10f, 10f), AlturaInstantiateOBJ, Random.Range(-10f, 10f)), Quaternion.identity);
        }
    }
}
