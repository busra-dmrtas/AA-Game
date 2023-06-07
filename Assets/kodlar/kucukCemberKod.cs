using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCemberKod : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float hiz = 10;
    public bool duracak = false;
    public GameObject oyunYoneticisi;

    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisiTag");
    }
    private void FixedUpdate()
    {
        if (!duracak)
        {
            //k���k �ember ve �ubu�un yukar� do�ru gitmesini sa�l�yor
            rigidbody.MovePosition(rigidbody.position + Vector2.up * Time.deltaTime * hiz);
         
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "donenCemberTag")
        {
            transform.SetParent(collision.transform);
            //burada yukar� gitme i�lemi bitecek...
            duracak = true;
        }
        if (collision.tag=="kucukCemberTag")
        {
            oyunYoneticisi.GetComponent<oyunYoneticisiKodu>().OyunBitti();
        }
    }
}
