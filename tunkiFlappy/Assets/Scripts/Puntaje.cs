using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Puntaje : MonoBehaviour
{
    public static int puntaje = 0;

    public Text Record;
    


    // Start is called before the first frame update
    void Start()
    {
        
        puntaje = 0;
        Record.text = PlayerPrefs.GetInt("record",0).ToString();

        
        //PlayerPrefs.SetInt("Record", puntaje);

        //Record.text = puntaje.ToString();
        //Record.text = PlayerPrefs.GetInt("Record", 0).ToString();

    }

    // Update is called once per frame
    //public void Puntaje()
    
        //if (puntaje > PlayerPrefs.GetInt("Record", 0))
        
            //PlayerPrefs.SetInt("Record", puntaje);
            //Record.text = puntaje.ToString();
    

    void Update()
    {
        GetComponent<Text>().text = puntaje.ToString();
    
         if (puntaje > PlayerPrefs.GetInt("Record", 0))
        {
            PlayerPrefs.SetInt("Record", puntaje);
            Record.text = puntaje.ToString();
          
        }
    }
}
