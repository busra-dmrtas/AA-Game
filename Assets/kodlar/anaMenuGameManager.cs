using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //sahneyi a�mak i�in kulland���m�z k�t�phane

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
