using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaTubos : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
        Destroy(gameObject, 2);
    }
}
