﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioSimulacion : MonoBehaviour
{
    public CambioMasaBolaDomino tomarSlidersSimulacion1;
    //public CambioMasaSubeBaja tomarSlidersSimulacion2;


    public Button BtnIniciarSimulacion;
    private GameObject BotonArrancarSimulacion;

    public Button BtnRestartEscenaDomino;
    public Button BtnAbrirSegundaSimulacion;

    //public Button BtnRestartEscenaImpulsoRampa;
    //public Button BtnAbrirPrimeraSimulacion;
    //public Button BtnAbrirTerceraSimulacion;

    public Text TxtExplicacionDominoEnImgDegrade;
    private GameObject TxtExplicacionDelDomino;

    //public Text TxtExplicacionImpulsoEnRampaEnImgDegrade;
    //private GameObject TxtExplicacionDelImpulsoEnRampa;

    public Image ImgDegradeNegroPreSimulacion;
    private GameObject ImgDegradeNegroEnUI; // ERA NECESARIO PARA LUEGO BORRAR EL DEGRADE NEGRO!!!

    void Start()
    {
        Time.timeScale = 0f; // HABIA QUE PONERLO AL COMIENZO DEL Start, SI NO, LA ESCENA ARRANCABA DIRECTO


        TxtExplicacionDominoEnImgDegrade = TxtExplicacionDelDomino.GetComponent<Text>();

        //TxtExplicacionImpulsoEnRampaEnImgDegrade = TxtExplicacionDelImpulsoEnRampa.GetComponent<Text>();

        ImgDegradeNegroPreSimulacion = ImgDegradeNegroEnUI.GetComponent<Image>(); // ESTO HACIA FALTA PARA BORRAR EL DEGRADE NEGRO!!!


        BtnIniciarSimulacion = BotonArrancarSimulacion.GetComponent<Button>();
        
        BtnRestartEscenaDomino = GetComponent<Button>();
        BtnAbrirSegundaSimulacion = GetComponent<Button>();


        //BtnRestartEscenaImpulsoRampa = GetComponent<Button>();
        //BtnAbrirPrimeraSimulacion = GetComponent<Button>();
        //BtnAbrirTerceraSimulacion = GetComponent<Button>();


        tomarSlidersSimulacion1.sliderMassBolita = GetComponent<Slider>(); // CON REFERENCIAR UNO SOLO DE LOS SLIDERS BASTÓ!!!!

        //tomarSlidersSimulacion2.sliderMassCuboImpulsador = GetComponent<Slider>();
    }

    
    void Update()
    {
        
    }

    public void IniciarSimulacion()
    {
        Time.timeScale = 1f;

        Destroy(TxtExplicacionDominoEnImgDegrade);
        Destroy(ImgDegradeNegroPreSimulacion);        
        Destroy(BtnIniciarSimulacion.gameObject);

        //Destroy(TxtExplicacionImpulsoEnRampaEnImgDegrade);


        // DESHABILITAMOS SLIDERS PARA NO HACER MODIFICACIONES SOBRE LA MARCHA, MIENTRAS SE EJECUTA EL ESCENARIO ACTUAL
        
        tomarSlidersSimulacion1.sliderMassBolita.interactable = false;
        tomarSlidersSimulacion1.sliderMassPiezasDomino.interactable = false;


        //tomarSlidersSimulacion2.sliderMassCuboImpulsador.interactable = false;
        //tomarSlidersSimulacion2.sliderMassCuboSiendoImpulsado.interactable = false;
        //tomarSlidersSimulacion2.sliderMassRampaSobrePuntoApoyo.interactable = false;
    }
}
