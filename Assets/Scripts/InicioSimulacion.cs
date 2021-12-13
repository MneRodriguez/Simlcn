using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioSimulacion : MonoBehaviour
{
    public CambioMasaBolaDomino tomarSlidersSimulacion1;
    
    public Button BtnIniciarSimulacion;
    private GameObject BotonArrancarSimulacion;

    public Button BtnRestartEscenaDomino;
    public Button BtnAbrirSegundaSimulacion;      

    public Text TxtExplicacionDominoEnImgDegrade;
    private GameObject TxtExplicacionDelDomino;
        
    public Image ImgDegradeNegroPreSimulacion;
    private GameObject ImgDegradeNegroEnUI; // ERA NECESARIO PARA LUEGO BORRAR EL DEGRADE NEGRO!!!

    void Start()
    {
        Time.timeScale = 0f; // HABIA QUE PONERLO AL COMIENZO DEL Start, SI NO, LA ESCENA ARRANCABA DIRECTO


        TxtExplicacionDominoEnImgDegrade = TxtExplicacionDelDomino.GetComponent<Text>();
                

        ImgDegradeNegroPreSimulacion = ImgDegradeNegroEnUI.GetComponent<Image>(); // ESTO HACIA FALTA PARA BORRAR EL DEGRADE NEGRO!!!


        BtnIniciarSimulacion = BotonArrancarSimulacion.GetComponent<Button>();
        
        BtnRestartEscenaDomino = GetComponent<Button>();
        BtnAbrirSegundaSimulacion = GetComponent<Button>();             

        tomarSlidersSimulacion1.sliderMassBolita = GetComponent<Slider>(); // CON REFERENCIAR UNO SOLO DE LOS SLIDERS BASTÓ!!!!
                
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

        // DESHABILITAMOS SLIDERS PARA NO HACER MODIFICACIONES SOBRE LA MARCHA, MIENTRAS SE EJECUTA EL ESCENARIO ACTUAL
        
        tomarSlidersSimulacion1.sliderMassBolita.interactable = false;
        tomarSlidersSimulacion1.sliderMassPiezasDomino.interactable = false;
        tomarSlidersSimulacion1.sliderRotacionPalaImpulsadora.interactable = false;
        tomarSlidersSimulacion1.sliderMassPala.interactable = false;
    }
}
