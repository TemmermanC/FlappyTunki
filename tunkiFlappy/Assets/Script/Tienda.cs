using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tienda : MonoBehaviour
{
    // Start is called before the first frame update
    public int Moneda01;
    public GameObject PanelExito;
    public GameObject PanelError;

    public Text txt_dinero;

    private void Awake()
    {
        txt_dinero.text = "Dinero: " + Moneda01;
    }

    public void Comprar(int precio_producto, string Nombre_Producto_) {

        if (Moneda01 - precio_producto >= 0)
        {
            Moneda01 -= precio_producto;
            txt_dinero.text = "Dinero: " + Moneda01;

            switch (Nombre_Producto_)
            {
                case "CERVEZA":
                    Debug.Log("CAMBIAR SKIN");
                    break;
                
            }

            PanelExito.GetComponent<Panel>().nombre_producto = Nombre_Producto_;
            PanelExito.SetActive(true);
        }
        else 
        {
            PanelError.GetComponent<Panel>().nombre_producto = Nombre_Producto_;
            PanelError.SetActive(true);
        }

    }


}
