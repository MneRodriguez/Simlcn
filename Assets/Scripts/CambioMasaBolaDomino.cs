using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioMasaBolaDomino : MonoBehaviour
{
    public Rigidbody rbDeLaBolitaDomino;
    public float valorMassPorDefecto = 1f;

    public Slider sliderMassBolita;
    void Start()
    {
        rbDeLaBolitaDomino = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    public void AjustarMassBolitaDomino()
    {
        valorMassPorDefecto = sliderMassBolita.value;
        rbDeLaBolitaDomino.mass = valorMassPorDefecto;
    }
}
