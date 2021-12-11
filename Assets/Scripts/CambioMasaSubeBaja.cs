using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioMasaSubeBaja : MonoBehaviour
{
    public Rigidbody rbCuboImpulsador;
    public float valorMasaCuboImpulsadorPorDefecto = 0f;
    public Slider sliderMassCuboImpulsador;
    public Text txtValorMasaCuboImpulsador;
    // VER SI AGREGO CAMBIO DE SCALE O ROTACION


    public Rigidbody rbCuboSiendoImpulsado;
    public float valorMasaCuboSiendoImpulsadorPorDefecto = 0f;
    public Slider sliderMassCuboSiendoImpulsado;
    public Text txtValorMasaCuboSiendoImpulsado;
    // VER SI AGREGO CAMBIO DE SCALE O ROTACION DE LA RAMPA


    public Rigidbody rbRampaSobrePuntoApoyo;
    public float valorMasaRampaSobrePuntoApoyo = 0f;
    public Slider sliderMassRampaSobrePuntoApoyo;
    public Text txtValorMasaRampaSobrePuntoApoyo;
    // VER SI AGREGO CAMBIO DE SCALE O ROTACION DE LA RAMPA

    public Joint fixedJointDeRampa;


    void Start()
    {
        /*rbCuboImpulsador = GetComponent<Rigidbody>();
        txtValorMasaCuboImpulsador = GetComponent<Text>();

        rbCuboSiendoImpulsado = GetComponent<Rigidbody>();
        txtValorMasaCuboSiendoImpulsado = GetComponent<Text>();*/

        
    }

    
    void Update()
    {
        txtValorMasaCuboImpulsador.text = "Masa del cubo impulsador = " + sliderMassCuboImpulsador.value;

        txtValorMasaCuboSiendoImpulsado.text = "Masa del cubo siendo impulsado = " + sliderMassCuboSiendoImpulsado.value;

        // VER SI PONGO LO DEL CAMBIO DE SCALE O ROTACION DE LA RAMPA

        // ESTA LINEA HACE QUE SE ROMPA LA RAMPA APENAS ARRANCA LA ESCENA!!!

        if (valorMasaCuboImpulsadorPorDefecto == 20) // SI LA MASA DEL CUBO IMPULSADOR VALE 20 (misma cant que la rampa puede soportar)...
        {
            RomperRampa();
        }
    }

    public void AjusteMassCuboImpulsador()
    {
        valorMasaCuboImpulsadorPorDefecto = sliderMassCuboImpulsador.value;
        rbCuboImpulsador.mass = valorMasaCuboImpulsadorPorDefecto;
        // VER SI AGREGO CAMBIO DE SCALE
    }

    public void AjusteMassCuboSiendoImpulsado()
    {
        valorMasaCuboSiendoImpulsadorPorDefecto = sliderMassCuboSiendoImpulsado.value;
        rbCuboSiendoImpulsado.mass = valorMasaCuboSiendoImpulsadorPorDefecto;
        // VER SI AGREGO CAMBIO DE SCALE
    }

    public void RomperRampa()
    {
        //fixedJointDeRampa.breakForce = 20;       
        Destroy(GetComponent<FixedJoint>());        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rampa1") && valorMasaCuboImpulsadorPorDefecto == 20)
        {
            fixedJointDeRampa.breakForce = 20;
            RomperRampa();
        }
    }
}
