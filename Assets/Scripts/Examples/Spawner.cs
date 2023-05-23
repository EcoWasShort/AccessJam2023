using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    //[SerializeField] permette di agganciare oggetti all'interno dello script
    [SerializeField]
    public GameObject CubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //(Arg1,Arg2) Arg1 : Messaggio, Arg2 : Oggetto collegato
        Debug.Log("Sono Spawnato con " + gameObject.name , gameObject);
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){ //Input è un oggetto contenente ogni funzione di tastiera dall'utente, GetMouseButton è il mouse, 0 = L e 1 = R
        //Spawna (Instanzia) un prefabbricato, ha diversi argomenti, l'oggetto agganciato in se, Coordinate e anche rotazione, è tutto modificabile, poi ho aggiunto della randomicità per i le Coordinate
        Instantiate(CubePrefab,new Vector3(Random.Range(-10,10),Random.Range(-10,10)),CubePrefab.transform.rotation);
        }
    }
}
