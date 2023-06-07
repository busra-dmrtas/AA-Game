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
            //küçük çember ve çubuðun yukarý doðru gitmesini saðlýyor
            rigidbody.MovePosition(rigidbody.position + Vector2.up * Time.deltaTime * hiz);
         
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "donenCemberTag")
        {
            transform.SetParent(collision.transform);
            //burada yukarý gitme iþlemi bitecek...
            duracak = true;
        }
        if (collision.tag=="kucukCemberTag")
        {
            oyunYoneticisi.GetComponent<oyunYoneticisiKodu>().OyunBitti();
        }
    }
}
