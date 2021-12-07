using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioMasaBolaDomino : MonoBehaviour
{
    public Rigidbody rbDeLaBolitaDomino;
    public float valorMassPorDefecto = 0f;

    public Slider sliderMassBolita;

    public Text txtValorMasaBolita;
    void Start()
    {
        rbDeLaBolitaDomino = GetComponent<Rigidbody>();

        txtValorMasaBolita = GetComponent<Text>();
                
    }

    
    void Update()
    {
        txtValorMasaBolita.text = "Masa de la bola = " + sliderMassBolita.value;
    }

    public void AjustarMassBolitaDomino()
    {
        valorMassPorDefecto = sliderMassBolita.value;
        rbDeLaBolitaDomino.mass = valorMassPorDefecto;
    }
}
