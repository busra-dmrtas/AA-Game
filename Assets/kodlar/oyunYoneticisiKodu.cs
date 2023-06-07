using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunYoneticisiKodu : MonoBehaviour
{
    GameObject donenCember;
    GameObject kaynak;
    
    void Start()
    {
        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
            
    }

    
    void Update()
    {
        
    }

    public void OyunBitti()
    {
        //oyun bitirme iþlemi yapýlacak...
        Debug.Log("oyun bitti");
        donenCember.GetComponent<dondurme>().enabled = false;
        kaynak = GameObject.FindGameObjectWithTag("kaynakTag");
        kaynak.GetComponent<kaynakKod>().enabled = false;
    }
}
