using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenarios : MonoBehaviour
{
        

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perdiste()
    {
        SceneManager.LoadScene(3);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(1);
    }

        public void Tienda()
    {
        SceneManager.LoadScene(2);
    }

    public void Navidad()
    {
        SceneManager.LoadScene(4);
    }

    public void Halloween()
    {
        SceneManager.LoadScene(5);
    }

    public void Skins()
    {
        SceneManager.LoadScene(6);
    }
}


