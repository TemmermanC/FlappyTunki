using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public string Nombre_Producto;
    public int Precio_Producto;

    public void ComprarProducto()
    {
        Debug.Log("Estas comprando un " + Nombre_Producto);
        GameObject.Find("Tienda").GetComponent<Tienda>().Comprar(Precio_Producto, Nombre_Producto);

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
