using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundButton : MonoBehaviour
{
    public GameObject[] activate;
   
    bool Activated = false;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("Player") && Activated == false){

            GetComponent<Animator>().Play("Activate");
            for (int i=0; i < activate.Length;i++){
                activate[i].GetComponent<Animator>().Play("Activate");
            }
            
        }
    }
}
