using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioSimulacion : MonoBehaviour
{
    public Button BtnIniciarSimulacion;
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

        BtnIniciarSimulacion = GetComponent<Button>();
        BtnRestartEscenaDomino = GetComponent<Button>();
        BtnAbrirSegundaSimulacion = GetComponent<Button>();

                
        BtnRestartEscenaDomino.enabled = false;
        BtnAbrirSegundaSimulacion.enabled = false;

        
    }

    
    void Update()
    {
        
    }

    public void IniciarSimulacion()
    {
        Time.timeScale = 1f;

        Destroy(TxtExplicacionDominoEnImgDegrade);
        Destroy(ImgDegradeNegroPreSimulacion);
        Destroy(ImgDegradeNegroEnUI.gameObject);
        Destroy(BtnIniciarSimulacion.gameObject);

        BtnRestartEscenaDomino.enabled = true;
        BtnAbrirSegundaSimulacion.enabled = true;

        
    }
}
