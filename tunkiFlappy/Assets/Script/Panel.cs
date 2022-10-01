using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    // Start is called before the first frame update

    public Text cuadro_text;
    public string nombre_producto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Debug.Log("PRENDIDO");
        
        if(gameObject.name == "PanelCompraExito")
        {
           cuadro_text.text = "Compraste " + nombre_producto;
        }

        else
        {
           cuadro_text.text = "No te alcanza para " + nombre_producto;
        }
    }

    private void OnDisable()
    {
        Debug.Log("APAGADO");
    }

}
