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

    public Rigidbody rbDeLasPiezasDomino;
    public float valorMassPiezasDominoPorDefecto = 0f;
    public Slider sliderMassPiezasDomino;
    public Text txtValorMasaPiezasDomino;


    public Transform palaImpulsadoraDeBolita;
    public float valorRotacionDeLaPalaImpulsadora = 0f;
    public Slider sliderRotacionPalaImpulsadora;
    public Text txtValorRotacionPalaImpulsadora;

    public Rigidbody rbDeLaPala;
    public float valorMassPala;
    public Slider sliderMassPala;
    public Text txtValorMasaPala;

    void Start()
    {
        /*rbDeLaBolitaDomino = GetComponent<Rigidbody>(); //NO DEBIA PONER ESTAS LINEAS, SI NO EN EL INSPECTOR NO SE REFERENCIABAN AL ARRANCAR LA ESCENA
        txtValorMasaBolita = GetComponent<Text>();

        //rbDeLasPiezasDomino = GetComponent<Rigidbody>();
        txtValorMasaPiezasDomino = GetComponent<Text>();*/

        



    }

    
    void Update()
    {
        // ESTOS DEBEN IR ACA, SI NO NO ANDAN!!!!
        txtValorMasaBolita.text = "Masa de la bola = " + sliderMassBolita.value;

        txtValorMasaPiezasDomino.text = "Masa de las piezas del dominó = " + sliderMassPiezasDomino.value;

        txtValorRotacionPalaImpulsadora.text = "Rotacion de la pala impulsadora = " + sliderRotacionPalaImpulsadora.value + "°";
        txtValorMasaPala.text = "Masa de la pala = " + sliderMassPala.value;
    }

    public void AjustarMassBolitaDomino()
    {
        valorMassPorDefecto = sliderMassBolita.value;
        rbDeLaBolitaDomino.mass = valorMassPorDefecto;
    }

    public void AjustarMassPiezasDomino()
    {
        valorMassPiezasDominoPorDefecto = sliderMassPiezasDomino.value;
        rbDeLasPiezasDomino.mass = valorMassPiezasDominoPorDefecto;
    }


    public void RegularRotacionPalaImpulsadora()
    {
        valorRotacionDeLaPalaImpulsadora = sliderRotacionPalaImpulsadora.value;
        palaImpulsadoraDeBolita.transform.localEulerAngles = new Vector3(-valorRotacionDeLaPalaImpulsadora, 0f, 0f); // HABIA QUE PONERLO CON EL '-' O SEA EN NEGATIVO PARA QUE EL OBJETO GIRE EN POSITIVO, Y NO EN NEGATIVO COMO ME ESTABA PASANDO!!!
    }
    
    public void AjustarMassPala()
    {
        valorMassPala = sliderMassPala.value;
        rbDeLaPala.mass = valorMassPala;
    }
    
}
