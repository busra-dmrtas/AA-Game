using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //sahneyi açmak için kullandýðýmýz kütüphane

public class anaMenuGameManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OyunaBasla()
    {
        SceneManager.LoadScene("level1");

    }
    public void OyunuBitir()
    {
        Application.Quit();
    }
}
