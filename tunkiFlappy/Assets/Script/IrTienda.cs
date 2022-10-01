using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrTienda : MonoBehaviour

{
    public GameObject canvasPerdiste;
    // Start is called before the first frame update


    public void Tienda()
    {
        SceneManager.LoadScene(2);
    }
}
