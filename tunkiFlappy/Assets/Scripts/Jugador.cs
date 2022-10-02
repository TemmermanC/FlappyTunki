using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rb;
    public Escenarios ControladorEscena; 
    public InterstitialAdsButton adLoader;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        adLoader.ShowAd();

        ControladorEscena.Perdiste();


    }
}
