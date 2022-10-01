using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnT : MonoBehaviour
{

    public float TiempoMax = 1;
    private float TiempoInicial = 0;
    public GameObject obstaculo;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obstaculoNuevo = Instantiate(obstaculo);
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoInicial > TiempoMax)
        {
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-altura, altura), 0);
            TiempoInicial = 0;
        }
        else
        {
            TiempoInicial += Time.deltaTime;
        }
    }
}
