using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaynakKod : MonoBehaviour
{
    public GameObject atilacakKucukCember;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //yeni bir çember oluþturulacak...
            AtilacakCemberOlustur();
        }
    }
    void AtilacakCemberOlustur()
    {
        Instantiate(atilacakKucukCember,transform.position,transform.rotation);
    }
}
